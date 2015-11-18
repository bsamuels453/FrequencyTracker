using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FrequencyTracker
{

    struct Channel {
        public long Frequency;
        public string OrgType;
        public string Usage;
        public string Detail;
        public string Callsign;
        public string Modulation;
        public string Type;
        public string Content;
    }


    public partial class Form1 : Form
    {
        List<Channel>  _channels;


        public string[] WriteSafeReadAllLines(String path)
        {
            using (var csv = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(csv))
            {
                List<string> file = new List<string>();
                while (!sr.EndOfStream)
                {
                    file.Add(sr.ReadLine());
                }

                return file.ToArray();
            }
        }

        public Form1()
        {
            try
            {
            var rawChannels = WriteSafeReadAllLines("freqs.csv").Select(l => l.Split(','));
                var area = rawChannels.First().ToArray();
                rawChannels = rawChannels.Skip(1);


                _channels = new List<Channel>(1000);
                foreach (var rchannel in rawChannels)
                {
                    var c = new Channel { Frequency = (long)(double.Parse(rchannel[2]) * 1000000), OrgType = rchannel[0], Usage = rchannel[1], Callsign = rchannel[3], Detail = rchannel[6], Content = rchannel[9], Modulation = rchannel[8], Type = rchannel[4] };
                    _channels.Add(c);
                }
                _channels.Sort(delegate(Channel a, Channel b)
                {
                    return a.Frequency.CompareTo(b.Frequency);
                });

                InitializeComponent();
                DataAreaBox.Text = area[0];
            }
            catch(FileNotFoundException)
            {
                Debug.Assert(false,"No freqs.csv file found, use the Bandplan download tool to get the allocated frequencies for your area.");
                throw new Exception();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string _convertToReadable(long freq)
        {
            if (freq >= 1000000000)
            {
                //giga
                var suffix = "GHz";
                var constant = ((double)freq) / 1000000000.0;
                return constant.ToString() + " " + suffix;
            }
            if (freq < 1000000000 && freq >= 1000000)
            {
                //mega
                var suffix = "MHz";
                var constant = ((double)freq) / 1000000.0;
                return constant.ToString() + " " + suffix;
            }
            //kilo
            var _suffix = "KHz";
            var _constant = ((double)freq) / 1000.0;
            return _constant.ToString() + " " + _suffix;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
                textBox1.Text = "0";
            var f = double.Parse(textBox1.Text);
            long multiplier = 0;
            if (comboBox1.Text.Equals("MHz"))
            {
                multiplier = 1000000;
            }
            if (comboBox1.Text.Equals("KHz"))
            {
                multiplier = 1000;
            }
            if (comboBox1.Text.Equals("GHz"))
            {
                multiplier = 1000000000;
            }

            var freq = (long)(f * multiplier);


            int midchannel = -1;
            for (int i = 0; i < _channels.Count(); i++)
            {
                if (_channels[i].Frequency >= freq)
                {
                    midchannel = i;
                    break;
                }
                if (i == _channels.Count() - 1)
                {
                    midchannel = _channels.Count() - 1;
                }

            }

            var channelsToDisplay = new List<Channel>();
            for (int i = midchannel-8; i <= midchannel+ 8 && i<_channels.Count(); i++)
            {
                if (i < 0)
                    continue;
                channelsToDisplay.Add(_channels[i]);
            }

            int idx = 0;
            channelsToDisplay = channelsToDisplay.OrderBy(s => Math.Abs(s.Frequency - freq)).ToList();
            dataGridView1.RowCount = channelsToDisplay.Count();
            foreach (var c in channelsToDisplay)
            {
                dataGridView1[0, idx].Value = _convertToReadable(Math.Abs(freq - c.Frequency));
                dataGridView1[1, idx].Value = _convertToReadable(c.Frequency);
                dataGridView1[2, idx].Value = c.OrgType;
                dataGridView1[3, idx].Value = c.Usage;
                dataGridView1[4, idx].Value = c.Detail;
                dataGridView1[5, idx].Value = c.Callsign;
                dataGridView1[6, idx].Value = c.Modulation;
                dataGridView1[7, idx].Value = c.Type;
                dataGridView1[8, idx].Value = c.Content;
                idx++;
            }


            int g = 5;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
