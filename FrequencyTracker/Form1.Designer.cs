namespace FrequencyTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FrequencyDelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrgType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Callsign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.DataAreaBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 64);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detected Signal Frequency";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(444, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find Channels";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FrequencyDelta,
            this.Frequency,
            this.OrgType,
            this.Usage,
            this.Detail,
            this.Callsign,
            this.Modulation,
            this.Type,
            this.Content});
            this.dataGridView1.Location = new System.Drawing.Point(18, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 434);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MHz",
            "KHz",
            "GHz"});
            this.comboBox1.Location = new System.Drawing.Point(444, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 30);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "MHz";
            // 
            // FrequencyDelta
            // 
            this.FrequencyDelta.HeaderText = "FrequencyDelta";
            this.FrequencyDelta.Name = "FrequencyDelta";
            this.FrequencyDelta.ReadOnly = true;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // OrgType
            // 
            this.OrgType.HeaderText = "Organization Type";
            this.OrgType.Name = "OrgType";
            this.OrgType.ReadOnly = true;
            this.OrgType.Width = 300;
            // 
            // Usage
            // 
            this.Usage.HeaderText = "Usage";
            this.Usage.Name = "Usage";
            this.Usage.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // Callsign
            // 
            this.Callsign.HeaderText = "Callsign";
            this.Callsign.Name = "Callsign";
            this.Callsign.ReadOnly = true;
            // 
            // Modulation
            // 
            this.Modulation.HeaderText = "Modulation";
            this.Modulation.Name = "Modulation";
            this.Modulation.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Content
            // 
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Area Loaded:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DataAreaBox
            // 
            this.DataAreaBox.AutoSize = true;
            this.DataAreaBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataAreaBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataAreaBox.Location = new System.Drawing.Point(659, 45);
            this.DataAreaBox.Name = "DataAreaBox";
            this.DataAreaBox.Size = new System.Drawing.Size(46, 24);
            this.DataAreaBox.TabIndex = 10;
            this.DataAreaBox.Text = "n/a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 560);
            this.Controls.Add(this.DataAreaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Frequency Finder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrequencyDelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrgType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Callsign;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DataAreaBox;
    }
}

