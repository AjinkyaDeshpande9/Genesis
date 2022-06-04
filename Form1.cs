using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genesis
{
    public partial class Login : Form
    {
        private string text;
        private int len = 0;
        public Login()
        {
            InitializeComponent();
        }

       private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                VerifyLable.Text = VerifyLable.Text + text.ElementAt(len);
                len++;
            }
            
            if (len > 0)
            {
                using (System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\Projects\Genesis\Resources\Sound_LableLoad.wav"))
                {
                    player.Play();
                    
                }
            }
            else
            {
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            text = VerifyLable.Text;
            VerifyLable.Text = "";
            timer1.Start();
           
        }

      
    }
}
