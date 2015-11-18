using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BandplanParser;

namespace BandplanDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Text = textBox1.Text.Replace("https", "http");
            BandplanParser.BandplanParser.DownloadCSV(textBox1.Text);
            button1.Enabled = true;
            label2.Text = "Download completed.";
        }
    }
}
