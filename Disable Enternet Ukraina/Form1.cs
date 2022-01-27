using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Disable_Enternet_Ukraina
{
   
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = "https://nl05.mp3snow.com/0ca94ceb5cb77afac810e/%D0%93%D0%B8%D0%BC%D0%BD%20%D0%A3%D0%BA%D1%80%D0%B0%D0%B8%D0%BD%D1%8B%20BASS%20BOOSTED.mp3";
            wplayer.controls.play();

            Form2 frm = new Form2();
                frm.Show();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
