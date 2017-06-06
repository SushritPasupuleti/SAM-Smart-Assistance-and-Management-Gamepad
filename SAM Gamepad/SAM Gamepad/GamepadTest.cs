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
    public partial class GamepadTest : Form
    {
        string Username = Environment.UserName;
        SpeechRecognitionEngine _RecEng = new SpeechRecognitionEngine();
        string GameSyn = Settings.Default.GmSyn.ToString();
        string GameCom = Settings.Default.GmC.ToString();
        StreamReader sr;
        public GamepadTest()
        {
            InitializeComponent();
            Closethis.BackgroundImage = Image.FromFile(@"C:\Users\" + Username + "\\AppData\\Roaming\\SAM.2015.Media\\close2.png");
            sr = new StreamReader(GameSyn);
            txtSyntaxes.Text = sr.ReadToEnd();
            sr.Close();
            sr = new StreamReader(GameCom);
            txtCommands.Text = sr.ReadToEnd();
            sr.Close();
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
        private void N1_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "1";
        }

        private void Closethis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void N2_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "2";
        }

        private void N3_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "3";
        }

        private void N4_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "4";
        }

        private void N5_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "5";
        }

        private void N6_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "6";
        }

        private void N7_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "7";
        }

        private void N8_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "8";
        }

        private void N9_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "9";
        }

        private void N0_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "0";
        }

        private void NBKSPC_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{BKSP}";
        }

        private void NESC_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{ESC}";
        }

        private void NTAB_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{TAB}";
        }

        private void NQ_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "Q";
        }

        private void NW_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "W";
        }

        private void NE_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "E";
        }

        private void NR_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "R";
        }

        private void NT_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "T";
        }

        private void NY_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "Y";
        }

        private void NU_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "U";
        }

        private void NI_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "I";
        }

        private void NO_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "O";
        }

        private void NP_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "P";
        }

        private void NBACKSLSH_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "\\";
        }

        private void NDEL_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{DEL}";
        }

        private void NCAPS_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{CAPSLOCK}";
        }

        private void NA_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "A";
        }

        private void NS_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "S";
        }

        private void ND_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "D";
        }

        private void NF_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "F";
        }

        private void NG_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "G";
        }

        private void NH_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "H";
        }

        private void NJ_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "J";
        }

        private void NK_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "K";
        }

        private void NL_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "L";
        }

        private void NENTER_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{ENTER}";
        }

        private void NPGU_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{PGUP}";
        }

        private void NSHIFT_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "+";
        }

        private void NZ_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "Z";
        }

        private void NX_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "X";
        }

        private void NC_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "C";
        }

        private void NV_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "V";
        }

        private void NB_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "B";
        }

        private void NN_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "N";
        }

        private void NM_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "M";
        }

        private void NLESS_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "<";
        }

        private void NGREAT_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = ">";
        }

        private void NFSLSH_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "/";
        }

        private void NPGD_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{PGDN}";
        }

        private void NCTRL_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "^";
        }

        private void NFN_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "This Key still doesn't have a Syntax";
        }

        private void NALT_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "%";
        }

        private void NSPSC_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = " ";
        }

        private void GamepadTest_Load(object sender, EventArgs e)
        {

        }

        private void NApprox_Click(object sender, EventArgs e)
        {
           SyntaxText.Text = "~";
        }

        private void NALT2_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "%";
        }

        private void NCTRL2_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "^";
        }

        private void NEND_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{END}";
        }

        private void NHOME_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{HOME}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.CreateText(GameSyn))
            {
                sw.Write(txtSyntaxes.Text);
                sw.Close();
            }
            using (StreamWriter sw = File.CreateText(GameCom))
            {
                sw.Write(txtCommands.Text);
                sw.Close();
            }
        }

        private void SyntaxClear_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "";
        }

        private void NUP_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{UP}";
        }

        private void NLFT_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{LEFT}";
        }

        private void NDWN_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{DOWN}";
        }

        private void NRGHT_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "{RIGHT}";
        }

        private void NWU_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "W";
        }

        private void NAL_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "A";
        }

        private void NSD_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "S";
        }

        private void NDR_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "D";
        }


    }
}
