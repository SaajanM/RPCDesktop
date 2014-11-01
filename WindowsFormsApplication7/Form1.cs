using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Resources;





namespace WindowsFormsApplication7
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

          
        }
        
        
         private Form2 otherForm = new Form2();
        
        public void OtherFormTops()
        {
           string tops= otherForm.victory;
 
        }

        
        SoundPlayer win = new SoundPlayer(WindowsFormsApplication7.Properties.Resources.TadaSound);
        SoundPlayer lose = new SoundPlayer(WindowsFormsApplication7.Properties.Resources.fail);
        SoundPlayer tie = new SoundPlayer(WindowsFormsApplication7.Properties.Resources.Tie);
        
        private void MusicIf()
        {
            
            if (otherForm.MusicOnOff.Text == "Off")
            {
                 win = new SoundPlayer(WindowsFormsApplication7.Properties.Resources._2383539);
                 lose = new SoundPlayer(WindowsFormsApplication7.Properties.Resources._2383539);
                 tie = new SoundPlayer(WindowsFormsApplication7.Properties.Resources._2383539);
            }
        }
        private void are_you_ready()

        {
           var results= MessageBox.Show("ARE YOU READY!", "RPC CHALLENGE", MessageBoxButtons.YesNo);
        
           if (results == System.Windows.Forms.DialogResult.No) {

               this.Close();
           }
        }
        
                
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            yourPictureChoice.Image = rockPicture.Image;

            
                    make_computer_choice();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            yourPictureChoice.Image = paperPicture.Image;
            
            make_computer_choice();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            yourPictureChoice.Image = scissorPicture.Image;
            make_computer_choice();
            
        }

       private void make_computer_choice()
        {
            int number = random_number_genertor.Next(3);
            if (number == 0)
            {
                computerPictureChoice.Image = rockPicture.Image;
            }
            else if (number == 1)
            {
                computerPictureChoice.Image = paperPicture.Image;
            }
            else
            {
                computerPictureChoice.Image = scissorPicture.Image;
            }
            see_who_wins();
           
       }
       
        private void see_who_wins()
        {
            if (otherForm.WallPaper.Text == "Volcano")
            {
                BackgroundImage = WindowsFormsApplication7.Properties.Resources.volcano1;
            }
            else if (otherForm.WallPaper.Text == "Ocean")
            {
                BackgroundImage = WindowsFormsApplication7.Properties.Resources.Ocean;
            }
            else if (otherForm.WallPaper.Text == "Beach")
            {
                BackgroundImage = WindowsFormsApplication7.Properties.Resources.beach1;
            }
            else if (otherForm.WallPaper.Text == "Sky")
            {
                BackgroundImage = WindowsFormsApplication7.Properties.Resources.sky;
            }
            else if (otherForm.WallPaper.Text == "None")
            {
                BackgroundImage = null;
            }
            else if (otherForm.WallPaper.Text == Path.GetFileNameWithoutExtension(otherForm.file))
            {
                BackgroundImage = Image.FromFile(otherForm.file);
            }
            else if (otherForm.WallPaper.Text == Path.GetFileNameWithoutExtension(otherForm.file1))
            {
                BackgroundImage = Image.FromFile(otherForm.file1);
            }
            else if (otherForm.WallPaper.Text == Path.GetFileNameWithoutExtension(otherForm.file2))
            {
                BackgroundImage = Image.FromFile(otherForm.file2);
            }
            else if (otherForm.WallPaper.Text == Path.GetFileNameWithoutExtension(otherForm.file3))
            {
                BackgroundImage = Image.FromFile(otherForm.file3);
            }
            else if (otherForm.WallPaper.Text == Path.GetFileNameWithoutExtension(otherForm.file4))
            {
                BackgroundImage = Image.FromFile(otherForm.file4);
            }
            else if (otherForm.WallPaper.Text == Path.GetFileNameWithoutExtension(otherForm.file5))
            {
                BackgroundImage = Image.FromFile(otherForm.file5);
            }
            else if (otherForm.WallPaper.Text == Path.GetFileNameWithoutExtension(otherForm.file6))
            {
                BackgroundImage = Image.FromFile(otherForm.file6);
            }
            else if (otherForm.WallPaper.Text == Path.GetFileNameWithoutExtension(otherForm.file7))
            {
                BackgroundImage = Image.FromFile(otherForm.file7);
            }
            else if (otherForm.WallPaper.Text == Path.GetFileNameWithoutExtension(otherForm.file8))
            {
                BackgroundImage = Image.FromFile(otherForm.file8);
            }
            else if (otherForm.WallPaper.Text == Path.GetFileNameWithoutExtension(otherForm.file9))
            {
                BackgroundImage = Image.FromFile(otherForm.file9);
            }
            if(yourPictureChoice.Image==rockPicture.Image&&computerPictureChoice.Image==paperPicture.Image){
                MusicIf();
                lose.Play();
                var interger=   Convert.ToInt32(lossesEditBox.Text);
             interger++;
             lossesEditBox.Text = interger.ToString();
             face.Image = WindowsFormsApplication7.Properties.Resources.sadFace;
                
            }
            else if (yourPictureChoice.Image == paperPicture.Image && computerPictureChoice.Image == scissorPicture.Image)
            {
                MusicIf();
                lose.Play();
                var interger = Convert.ToInt32(lossesEditBox.Text);
                interger++;
                lossesEditBox.Text = interger.ToString();
                face.Image = WindowsFormsApplication7.Properties.Resources.sadFace;
            }
            else if (yourPictureChoice.Image == scissorPicture.Image && computerPictureChoice.Image == rockPicture.Image)
            {
                MusicIf();
                lose.Play();
                var interger = Convert.ToInt32(lossesEditBox.Text);
                interger++;
                lossesEditBox.Text = interger.ToString();
                face.Image = WindowsFormsApplication7.Properties.Resources.sadFace;
            }
            else if (yourPictureChoice.Image == paperPicture.Image && computerPictureChoice.Image == rockPicture.Image)
            {
                MusicIf();
                win.Play();
                var interger = Convert.ToInt32(winsEditBox.Text);
                interger++;
                winsEditBox.Text = interger.ToString();
                face.Image = WindowsFormsApplication7.Properties.Resources.happyFace;
            }
            else if (yourPictureChoice.Image == scissorPicture.Image && computerPictureChoice.Image == paperPicture.Image)
            {
                
                
           
           MusicIf();
                win.Play();
                var interger = Convert.ToInt32(winsEditBox.Text);
                interger++;
                winsEditBox.Text = interger.ToString();
                face.Image = WindowsFormsApplication7.Properties.Resources.happyFace;
            }
            else if (yourPictureChoice.Image == rockPicture.Image && computerPictureChoice.Image == scissorPicture.Image)
            {
                MusicIf();
                win.Play();
                var interger = Convert.ToInt32(winsEditBox.Text);
                interger++;
                winsEditBox.Text = interger.ToString();
                face.Image = WindowsFormsApplication7.Properties.Resources.happyFace;
                
            }
            else if (yourPictureChoice.Image ==computerPictureChoice.Image)
            {
                MusicIf();
                tie.Play();
                var interger = Convert.ToInt32(drawsEditBox.Text);
                interger++;
                drawsEditBox.Text = interger.ToString();
                face.Image = WindowsFormsApplication7.Properties.Resources.neutralFace;
            }
            if (lossesEditBox.Text == otherForm.victory)
            {
                MessageBox.Show("YOU LOSE!", "Results", MessageBoxButtons.OK);
            }
            else if (winsEditBox.Text == otherForm.victory)
            {
                MessageBox.Show("YOU WIN!", "Results", MessageBoxButtons.OK);
            }
            else if (drawsEditBox.Text == otherForm.victory)
            { 
                MessageBox.Show("TIE!", "Results", MessageBoxButtons.OK); 
            }
            if (winsEditBox.Text == otherForm.victory || lossesEditBox.Text == otherForm.victory || drawsEditBox.Text == otherForm.victory)
            {
                var results = MessageBox.Show("Would you like to exit?", "RPC CHALLENGE", MessageBoxButtons.YesNo);

                if (results == System.Windows.Forms.DialogResult.Yes)
                {

                    this.Close();
                }
                else
                {
                    drawsEditBox.Text = "0";
                    lossesEditBox.Text = "0";
                    winsEditBox.Text = "0";
                }
            }
        
        }
        
        Random random_number_genertor = new Random();

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            are_you_ready();
            OtherFormTops();
            if (otherForm.WallPaper.Text == "Volcano")
            {
                BackgroundImage = WindowsFormsApplication7.Properties.Resources.volcano1;
            }
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            drawsEditBox.Text = "0";
            lossesEditBox.Text = "0";
            winsEditBox.Text = "0";
        }
        private void Ok_Click(object sender, EventArgs e)
        {
           
            OtherFormTops();
            
        }
        private void Options_Click(object sender, EventArgs e)
        {
            otherForm.Show();

        }

        

        
        
    }
}


