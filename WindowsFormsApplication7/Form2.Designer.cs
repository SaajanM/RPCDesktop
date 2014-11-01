namespace WindowsFormsApplication7
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.MusicOnOff = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.wins = new System.Windows.Forms.TextBox();
            this.WallPaper = new System.Windows.Forms.ComboBox();
            this.textbox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filepath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // MusicOnOff
            // 
            this.MusicOnOff.FormattingEnabled = true;
            this.MusicOnOff.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.MusicOnOff.Location = new System.Drawing.Point(12, 115);
            this.MusicOnOff.Name = "MusicOnOff";
            this.MusicOnOff.Size = new System.Drawing.Size(137, 21);
            this.MusicOnOff.TabIndex = 0;
            this.MusicOnOff.Text = "On";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Sound";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(380, 315);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Number of wins until victory";
            // 
            // wins
            // 
            this.wins.Location = new System.Drawing.Point(31, 38);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(100, 20);
            this.wins.TabIndex = 4;
            this.wins.Text = "10";
            this.wins.TextChanged += new System.EventHandler(this.wins_TextChanged);
            // 
            // WallPaper
            // 
            this.WallPaper.FormattingEnabled = true;
            this.WallPaper.Items.AddRange(new object[] {
            "Volcano",
            "Ocean",
            "Beach",
            "Sky",
            "None"});
            this.WallPaper.Location = new System.Drawing.Point(12, 193);
            this.WallPaper.MaxDropDownItems = 15;
            this.WallPaper.Name = "WallPaper";
            this.WallPaper.Size = new System.Drawing.Size(137, 21);
            this.WallPaper.TabIndex = 5;
            this.WallPaper.Text = "Volcano";
            // 
            // textbox3
            // 
            this.textbox3.Location = new System.Drawing.Point(31, 167);
            this.textbox3.Name = "textbox3";
            this.textbox3.ReadOnly = true;
            this.textbox3.Size = new System.Drawing.Size(100, 20);
            this.textbox3.TabIndex = 6;
            this.textbox3.Text = "Wall Paper";
            this.textbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add An Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Image Directory";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filepath
            // 
            this.filepath.Location = new System.Drawing.Point(328, 74);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(525, 20);
            this.filepath.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Open";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.WallPaper);
            this.Controls.Add(this.wins);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MusicOnOff);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox MusicOnOff;
        public System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox wins;
        public System.Windows.Forms.ComboBox WallPaper;
        private System.Windows.Forms.TextBox textbox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}