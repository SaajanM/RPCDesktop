namespace WindowsFormsApplication7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.subtitlePicture = new System.Windows.Forms.PictureBox();
            this.scissorPicture = new System.Windows.Forms.PictureBox();
            this.paperPicture = new System.Windows.Forms.PictureBox();
            this.rockPicture = new System.Windows.Forms.PictureBox();
            this.yourPictureChoice = new System.Windows.Forms.PictureBox();
            this.computerPictureChoice = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drawsEditBox = new System.Windows.Forms.RichTextBox();
            this.lossesEditBox = new System.Windows.Forms.RichTextBox();
            this.winsEditBox = new System.Windows.Forms.RichTextBox();
            this.face = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.subtitlePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourPictureChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.face)).BeginInit();
            this.SuspendLayout();
            // 
            // subtitlePicture
            // 
            this.subtitlePicture.BackColor = System.Drawing.Color.Transparent;
            this.subtitlePicture.Image = global::WindowsFormsApplication7.Properties.Resources.cyw;
            this.subtitlePicture.Location = new System.Drawing.Point(12, 0);
            this.subtitlePicture.Name = "subtitlePicture";
            this.subtitlePicture.Size = new System.Drawing.Size(702, 166);
            this.subtitlePicture.TabIndex = 3;
            this.subtitlePicture.TabStop = false;
            // 
            // scissorPicture
            // 
            this.scissorPicture.BackColor = System.Drawing.Color.Transparent;
            this.scissorPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scissorPicture.Image = global::WindowsFormsApplication7.Properties.Resources.scissors;
            this.scissorPicture.Location = new System.Drawing.Point(514, 177);
            this.scissorPicture.Name = "scissorPicture";
            this.scissorPicture.Size = new System.Drawing.Size(200, 301);
            this.scissorPicture.TabIndex = 2;
            this.scissorPicture.TabStop = false;
            this.scissorPicture.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // paperPicture
            // 
            this.paperPicture.BackColor = System.Drawing.Color.Transparent;
            this.paperPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paperPicture.Image = global::WindowsFormsApplication7.Properties.Resources.paper;
            this.paperPicture.Location = new System.Drawing.Point(262, 176);
            this.paperPicture.Name = "paperPicture";
            this.paperPicture.Size = new System.Drawing.Size(204, 302);
            this.paperPicture.TabIndex = 1;
            this.paperPicture.TabStop = false;
            this.paperPicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // rockPicture
            // 
            this.rockPicture.BackColor = System.Drawing.Color.Transparent;
            this.rockPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rockPicture.Image = global::WindowsFormsApplication7.Properties.Resources.rock;
            this.rockPicture.Location = new System.Drawing.Point(12, 176);
            this.rockPicture.Name = "rockPicture";
            this.rockPicture.Size = new System.Drawing.Size(202, 301);
            this.rockPicture.TabIndex = 0;
            this.rockPicture.TabStop = false;
            this.rockPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // yourPictureChoice
            // 
            this.yourPictureChoice.BackColor = System.Drawing.Color.Transparent;
            this.yourPictureChoice.Location = new System.Drawing.Point(772, 25);
            this.yourPictureChoice.Name = "yourPictureChoice";
            this.yourPictureChoice.Size = new System.Drawing.Size(200, 301);
            this.yourPictureChoice.TabIndex = 4;
            this.yourPictureChoice.TabStop = false;
            // 
            // computerPictureChoice
            // 
            this.computerPictureChoice.BackColor = System.Drawing.Color.Transparent;
            this.computerPictureChoice.Location = new System.Drawing.Point(772, 346);
            this.computerPictureChoice.Name = "computerPictureChoice";
            this.computerPictureChoice.Size = new System.Drawing.Size(200, 301);
            this.computerPictureChoice.TabIndex = 5;
            this.computerPictureChoice.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(790, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "         Your Choice       ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(808, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Computer\'s Choice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(232, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "wins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(364, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "losses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(521, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "draws";
            // 
            // drawsEditBox
            // 
            this.drawsEditBox.Location = new System.Drawing.Point(494, 550);
            this.drawsEditBox.Name = "drawsEditBox";
            this.drawsEditBox.ReadOnly = true;
            this.drawsEditBox.Size = new System.Drawing.Size(100, 19);
            this.drawsEditBox.TabIndex = 0;
            this.drawsEditBox.Tag = "0";
            this.drawsEditBox.Text = "0";
            // 
            // lossesEditBox
            // 
            this.lossesEditBox.Location = new System.Drawing.Point(344, 551);
            this.lossesEditBox.Name = "lossesEditBox";
            this.lossesEditBox.ReadOnly = true;
            this.lossesEditBox.Size = new System.Drawing.Size(100, 19);
            this.lossesEditBox.TabIndex = 1;
            this.lossesEditBox.Text = "0";
            this.lossesEditBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // winsEditBox
            // 
            this.winsEditBox.Location = new System.Drawing.Point(205, 551);
            this.winsEditBox.Name = "winsEditBox";
            this.winsEditBox.ReadOnly = true;
            this.winsEditBox.Size = new System.Drawing.Size(100, 19);
            this.winsEditBox.TabIndex = 1;
            this.winsEditBox.Text = "0";
            // 
            // face
            // 
            this.face.BackColor = System.Drawing.Color.Transparent;
            this.face.Location = new System.Drawing.Point(1066, 176);
            this.face.Name = "face";
            this.face.Size = new System.Drawing.Size(297, 297);
            this.face.TabIndex = 14;
            this.face.TabStop = false;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Transparent;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.Red;
            this.reset.Location = new System.Drawing.Point(1234, 12);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(126, 32);
            this.reset.TabIndex = 15;
            this.reset.Text = "Reset!";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.Transparent;
            this.Options.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.ForeColor = System.Drawing.Color.Red;
            this.Options.Location = new System.Drawing.Point(1234, 550);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(126, 32);
            this.Options.TabIndex = 16;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = false;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication7.Properties.Resources.volcano1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 646);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.face);
            this.Controls.Add(this.drawsEditBox);
            this.Controls.Add(this.winsEditBox);
            this.Controls.Add(this.lossesEditBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computerPictureChoice);
            this.Controls.Add(this.yourPictureChoice);
            this.Controls.Add(this.subtitlePicture);
            this.Controls.Add(this.scissorPicture);
            this.Controls.Add(this.paperPicture);
            this.Controls.Add(this.rockPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors Challenge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subtitlePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourPictureChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.face)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rockPicture;
        private System.Windows.Forms.PictureBox paperPicture;
        private System.Windows.Forms.PictureBox scissorPicture;
        private System.Windows.Forms.PictureBox subtitlePicture;
        private System.Windows.Forms.PictureBox yourPictureChoice;
        private System.Windows.Forms.PictureBox computerPictureChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox winsEditBox;
        private System.Windows.Forms.RichTextBox lossesEditBox;
        private System.Windows.Forms.RichTextBox drawsEditBox;
        private System.Windows.Forms.PictureBox face;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button Options;

    }
}

