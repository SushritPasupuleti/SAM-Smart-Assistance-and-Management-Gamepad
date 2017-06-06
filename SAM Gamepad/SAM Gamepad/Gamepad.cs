using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using SAM_Gamepad.Properties;


namespace SAM_Gamepad
{
    public partial class Gamepad : Form
    {
        string Username = Environment.UserName;
        SpeechRecognitionEngine _RecEng = new SpeechRecognitionEngine();
        int i;
        String[] ArrayGS;
        String[] ArrayGC;
        string GameSyn = Settings.Default.GmSyn.ToString();
        string GameCom = Settings.Default.GmC.ToString();
        public Gamepad()
        {
            InitializeComponent();
            BackColor = Color.Pink;
            TransparencyKey = Color.Pink;
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private void TRGTS_Click(object sender, EventArgs e)
        {
            if (bdumbchk.Checked == true)
            {
                bdumbchk.Checked = false;

            }

            else
            {
                bdumbchk.Checked = true;

            }
        }

        private void bdumbchk_CheckedChanged(object sender, EventArgs e)
        {
            if (bdumbchk.Checked == true)
            {
                _RecEng.RecognizeAsyncCancel();
                TRGTS.BackgroundImage = global::SAM_Gamepad.Properties.Resources.Controller_icon;

            }

            else
            {
                _RecEng.RecognizeAsync(RecognizeMode.Multiple);
                TRGTS.BackgroundImage = global::SAM_Gamepad.Properties.Resources.ControllerAct_icon;
            }
        }

        private void Gamepad_Load(object sender, EventArgs e)
        {
            _RecEng.SetInputToDefaultAudioDevice();
            _RecEng.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"C:\Users\" + Username + "\\Documents\\SAM.2015\\SAM User Data\\GameCommands.txt")))));
            _RecEng.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(_recognizer_SpeechRecognizedG);
            _RecEng.RecognizeAsync(RecognizeMode.Multiple);
            ArrayGC = File.ReadAllLines(GameCom);
            ArrayGS = File.ReadAllLines(GameSyn);
        }


        void _recognizer_SpeechRecognizedG(object sender, SpeechRecognizedEventArgs e)
        {
            string Speech = e.Result.Text;
            i = 0;
            try
            {
                foreach (string line in ArrayGC)
                {
                    if (line == Speech)
                    {
                        SendKeys.Send(ArrayGS[i]);
                    }
                    i += 1;
                }
            }
            catch
            {
                i += 1;
               /// SAM.SpeakAsync("Please check the " + speech + " social command on line " + i + ". It appears to be missing a proper response");
            }
        }

        private void Closethis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NCTRL_Click(object sender, EventArgs e)
        {
            GamepadCEditor g = new GamepadCEditor();
            g.Show();
        }
        }
    }
