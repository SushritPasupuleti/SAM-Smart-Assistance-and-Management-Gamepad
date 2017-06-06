using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAM_Gamepad
{
    public partial class Gamepadslots : Form
    {
        public Gamepadslots()
        {
            InitializeComponent();
        }

        private void Closethis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Naprrox_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "~";
        }

        private void N1_Click(object sender, EventArgs e)
        {
            SyntaxText.Text = "1";
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

    }
}
