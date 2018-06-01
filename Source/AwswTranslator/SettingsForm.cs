using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwswTranslator
{
    public partial class SettingsForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void closeButtonSettings_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dragWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ade(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        public string GetLangFrom() => from.Text.ToLower();

        public string GetLangTo() => to.Text.ToLower();

        public bool GetReverseTranslation() => reverseTranslation.Checked;

        public bool GetBackup() => backup.Checked;

        public bool GetTranslateEverything() => translateEverything.Checked;
    }
}
