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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = "https://nl05.mp3snow.com/0ca94ceb5cb77afac810e/%D0%93%D0%B8%D0%BC%D0%BD%20%D0%A3%D0%BA%D1%80%D0%B0%D0%B8%D0%BD%D1%8B%20BASS%20BOOSTED.mp3";
            wplayer.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = "https://nl05.mp3snow.com/0ca94ceb5cb77afac810e/%D0%93%D0%B8%D0%BC%D0%BD%20%D0%A3%D0%BA%D1%80%D0%B0%D0%B8%D0%BD%D1%8B%20BASS%20BOOSTED.mp3";
            wplayer.controls.play();
            MessageBox.Show("НЕТ", "Москалів не прощають");
        }
    }
}
