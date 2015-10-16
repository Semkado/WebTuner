using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Xml;
using System.IO;
using WebRadio.Properties;

namespace WebRadio
{
    public partial class Form1 : Form
    {

        public static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        private int soundValue;
        private int oldSoundValue;
        private bool isMuted = false;
        private string radioUrl;
        private string xmlPath = @"..\..\Assets\RadioStations.xml";
        string[,] Radiostations;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soundUpdate(trackBarVolume.Value);
            LoadRadioStation();
            //Load ButtonImages
            buttonMute.Image = Resources.mute_no;
            buttonPlay.Image = Resources.play127_32;
            buttonStop.Image = Resources.pause12;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            player.URL = radioUrl;
            player.controls.play();
        }

        //Muted den Sound des Radios und ändert das Bild des Buttons
        private void buttonMute_Click(object sender, EventArgs e)
        {
            if (isMuted == true)
            {
                isMuted = false;
                soundUpdate(oldSoundValue);
                trackBarVolume.Value = oldSoundValue;
                oldSoundValue = 0;
                buttonMute.Image = Resources.mute_no;
            }
            else if (isMuted == false)
            {
                oldSoundValue = soundValue;
                soundUpdate(0);
                trackBarVolume.Value = 0;
                isMuted = true;
                buttonMute.Image = Resources.mute_yes;
            }
            else
            {
                MessageBox.Show("42", "Muted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void buttonStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            if (isMuted == true)
            {
                MessageBox.Show("Sound ist gemuted", "Muted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                soundUpdate(trackBarVolume.Value);
                soundValue = trackBarVolume.Value;
            }
        }

        /// <summary>
        /// Updatet die Anzeige der aktuellen Lautstärke
        /// </summary>
        /// <param name="sound">Aktuelle Lautstärke 0 bis 100</param>
        public void soundUpdate(int sound)
        {
            labelVolume.Text = ("Volume(" + sound + ")");
            player.settings.volume = sound;
        }

        //Lädt die Radiostationen aus einer XML-Datei
        public void LoadRadioStation()
        {
            int CounterData = 0;
            int CounterData2 = 0;

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);

            foreach (XmlNode node in doc.DocumentElement)
            {
                CounterData++;
            }

            Radiostations = new string[CounterData, 2];

            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                string url = node["URL"].InnerText;
                Radiostations[CounterData2, 0] = name;
                Radiostations[CounterData2, 1] = url;
                CounterData2++;
                listBox1.Items.Add(name);
            }
        }

        //Ändert die Radiourl, sobald ein anderer Eintrag in der Liste ausgewählt wird
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Bitte wähle einen Sender!","Kein Sender gewählt",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                radioUrl = Radiostations[listBox1.SelectedIndex, 1];
            }
        }
    }
}
