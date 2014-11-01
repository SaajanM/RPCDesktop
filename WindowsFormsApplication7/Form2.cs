using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Resources;

namespace WindowsFormsApplication7
{       
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Form1 beforeform;
        private void beforeformif()
        {
            if (beforeform == null)
            {
                beforeform = new Form1();
            }
        }
        public string file = null;
        public string file1 = null;
        public string file2 = null;
        public string file3 = null;
        public string file4 = null;
        public string file5 = null;
        public string file6 = null;
        public string file7 = null;
        public string file8 = null;
        public string file9 = null;
        public string victory
        {
            get
            {
                return wins.Text;
            }
        }
        public string Music
        {
            get
            {
                return MusicOnOff.Text;
            }
        }
        public string Wallpaper
        {
            get
            {
                return WallPaper.Text;
            }
        }
        public void Ok_Click(object sender, EventArgs e)
        {
            Hide();
            if (WallPaper.Text == "Volcano")
            {
                beforeform.BackgroundImage = WindowsFormsApplication7.Properties.Resources.volcano1;
            }
            else if (WallPaper.Text == "Ocean")
            {
                beforeform.BackgroundImage = WindowsFormsApplication7.Properties.Resources.Ocean;
            }
            else if (WallPaper.Text == "Beach")
            {
                beforeform.BackgroundImage = WindowsFormsApplication7.Properties.Resources.beach1;
            }
            else if (WallPaper.Text == "Sky")
            {
                beforeform.BackgroundImage = WindowsFormsApplication7.Properties.Resources.sky;
            }
            else if (WallPaper.Text == "None")
            {
                beforeform.BackgroundImage = null;
            }
            else if (WallPaper.Text == Path.GetFileNameWithoutExtension(filepath.Text))
            {

                beforeform.BackgroundImage = Image.FromFile(filepath.Text);
            }
            MessageBox.Show("If you changed the wallpaper play once to activate it!", "Notification", MessageBoxButtons.OK);
        }

        private void TouchFriendley()
        {
            WallPaper.Height = 50;
            MusicOnOff.Height = 50;
            wins.Height = 50;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
           
            filepath.Text = Path.GetFullPath(openFileDialog1.FileName);
            if (file == null)
            {
                file = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
            else if (file1 == null)
            {
                file1 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file1));
            }
            else if (file2 == null)
            {
                file2 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file2));
            }
            else if (file3 == null)
            {
                file3 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file3));
            }
            else if (file4 == null)
            {
                file4 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file4));
            }
            else if (file5 == null)
            {
                file5 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file5));
            }
            else if (file6 == null)
            {
                file6 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file6));
            }
            else if (file7 == null)
            {
                file7 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file7));
            }
            else if (file8 == null)
            {
                file8 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file8));
            }
            else if (file9 == null)
            {
                file9 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file9));
            }
            
        }

        
        

        private void wins_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            beforeformif();
            TouchFriendley();
        }
    }
}
