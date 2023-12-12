using System.Data.SQLite;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.Drawing;

namespace EzTTS
{
    public partial class ezTTS : Form
    {
        DB CMDS = new DB();
        Synth SYNTH = new Synth();
        public int speed = 0;
        public string voice = "IVONA 2 Salli";
        public ezTTS()
        {
            InitializeComponent();
            CB_SPEAK.Checked = true;
            LoadVoices();
            LoadList();
            Speedometer.Value = 10;
        }

        private void BTN_DEL_Click(object sender, EventArgs e)
        {
            del();
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            add();
        }



        private void BTN_SPEAK_PRESET_Click(object sender, EventArgs e)
        {
            string text = Commands.SelectedItem.ToString();
            SYNTH.speak(text, speed, voice);
        }

        private void BTN_SPEAK_Click(object sender, EventArgs e)
        {
            string text = TB_SPEAK.Text.ToString();
            SYNTH.speak(text, speed, voice);
            TB_SPEAK.Text = "";

        }

        void LoadList()
        {
            Commands.Text = "Load Commands";
            try
            {
                Commands.Items.Clear();
                string[] strArray = CMDS.Load();
                for (int i = 0; i < strArray.Length; i++)
                {
                    Commands.Items.Add(strArray[i]);
                }
                Commands.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (Commands.SelectedItem == "Nothing saved in DataBase yet" && CB_SPEAK.Checked != true)
            {
                SYNTH.speak(Commands.SelectedItem.ToString(), speed, voice);
            }
        }

        void add()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = commands.sqlite3"))
                {
                    connection.Open();

                    string cmd = TB_CMD.Text;

                    if (cmd == "")
                    {
                        if (CB_SPEAK.Checked != true)
                        {
                            SYNTH.speak("What do you want me to remember? Type into field below", speed, voice);
                        }
                        else
                        {
                            MessageBox.Show("What do you want me to remember? Type into field below");
                        }
                    }
                    else
                    {
                        SQLiteCommand command1 = new SQLiteCommand("INSERT INTO Commands('Command') VALUES(@Command)", connection);
                        command1.Parameters.AddWithValue("@Command", cmd);
                        command1.ExecuteNonQuery();
                        TB_CMD.Text = "";
                        if (CB_SPEAK.Checked != true)
                        {
                            SYNTH.speak("The Command " + cmd + " was added to Database", speed, voice);
                        }
                        else
                        {
                            MessageBox.Show("The Command " + cmd + " was added to Database!");
                        }
                        LoadList();
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                                                                                        //shows, what exactly went wrong, if something went wrong
            }
        }

        void del()
        {
            string chosen = '"' + Commands.SelectedItem.ToString() + '"';
            if (Commands.SelectedItem.ToString() == "Nothing saved in DataBase yet")
            {
                if (CB_SPEAK.Checked != true)
                {
                    SYNTH.speak("There is nothing to forget!", speed, voice);
                }
                else
                {
                    MessageBox.Show("There is nothing to forget!");
                }
                return;
            }
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = commands.sqlite3"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Commands WHERE Command = " + chosen + ";", connection))
                    {

                        command.ExecuteNonQuery();
                    }
                    if (CB_SPEAK.Checked != true)
                    {
                        SYNTH.speak("The Command " + chosen + " was deleted from database!", speed, voice);
                    }
                    else
                    {
                        MessageBox.Show("The Command " + chosen + " was deleted from database!");
                    }
                }
                LoadList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void TB_SPEAK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string text = TB_SPEAK.Text.ToString();
                SYNTH.speak(text, speed, voice);
                TB_SPEAK.Text = "";
            }
        }

        private void Speedometer_ValueChanged(object sender, EventArgs e)
        {
            speed = Int32.Parse(Speedometer.Value.ToString()) - 10;
        }

        private void VoiceChanger_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VoiceChanger.SelectedItem.ToString() != null)
            {
                voice = VoiceChanger.SelectedItem.ToString();
                if (CB_SPEAK.Checked != true)
                {
                    SYNTH.speak(voice + " chosen as Voice!", speed, voice);
                }
            }
        }

        private void BTN_RECORD_Click(object sender, EventArgs e)
        {
            string text = TB_SPEAK.Text.ToString();
            SYNTH.save(text, speed, voice);
            TB_SPEAK.Text = "";
            SYNTH.speak(text, speed, voice);
            if (CB_SPEAK.Checked != true)
            {
                SYNTH.speak("saved as MP3", speed, voice);
            }
            else
            {
                MessageBox.Show(text + " saved as Mp3");
            }
        }

        private async void VoiceChanger_KeyDown(object sender, KeyEventArgs e)
        {
            VoiceChanger.Enabled = false;
            if (CB_SPEAK.Checked != true)
            {
                SYNTH.speak("No tapa tapa here", speed, voice);
            }
            else
            {
                MessageBox.Show("No tapa tapa here :D");
            }
            await Task.Delay(1000);
            VoiceChanger.SelectedIndex = 0;
            VoiceChanger.Enabled = true;
        }

        private void TB_CMD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string text = TB_CMD.Text.ToString();
                add();
                TB_CMD.Text = "";
            }
        }

        private void LoadVoices()
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {

                // Output information about all of the installed voices.   
                Console.WriteLine("Installed voices -");
                foreach (InstalledVoice voice in synth.GetInstalledVoices())
                {
                    VoiceInfo info = voice.VoiceInfo;
                    string AudioFormats = "";
                    foreach (SpeechAudioFormatInfo fmt in info.SupportedAudioFormats)
                    {
                        AudioFormats += String.Format("{0}\n",
                        fmt.EncodingFormat.ToString());
                    }

                    VoiceChanger.Items.Add(info.Name);
                }
            }
            try
            {
                VoiceChanger.SelectedItem = voice;
            }
            catch
            {
                VoiceChanger.SelectedIndex = 0;
            }
        }
    }
}

