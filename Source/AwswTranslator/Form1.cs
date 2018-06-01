using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace AwswTranslator
{


    public partial class Form1 : Form
    {
        
        public static string targetLanguage = "ru";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();

            settingsWindow = new SettingsForm();
            settingsWindow.Show();
            settingsWindow.Visible = false;

            MessageBox.Show("Be careful with game's translation! Don't use it for game walkthrough!", "AwSW", MessageBoxButtons.OK);
        }

        private void Close_Click(object sender, EventArgs e) => Environment.Exit(Environment.ExitCode);

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

        private void dragWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private static string oldDragLabelText = string.Empty;

        private void file_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                oldDragLabelText = dragText.Text;

                string[] path = (e.Data.GetData(DataFormats.FileDrop) as string[])[0].Split('\\');

                dragText.Text = path[path.Length-1];

                e.Effect = DragDropEffects.All;
            } else
                e.Effect = DragDropEffects.None;
        }

        private void file_DragDrop(object sender, DragEventArgs e)
        {

            string file = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
            dragText.Text = file;

            Thread t = new Thread(
                    () => BeginParse(file));
            t.Start();
        }

        private void file_DragLeave(object sender, EventArgs e)
        {
            dragText.Text = oldDragLabelText;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();

            d.InitialDirectory = Application.StartupPath;
            d.Filter = "rpy files (*.rpy)|*.rpy|All files (*.*)|*.*";
            d.FilterIndex = 2;
            d.RestoreDirectory = true;

            if (d.ShowDialog() == DialogResult.OK)
            {
                Thread t = new Thread(
                    () => BeginParse(d.FileName));
                t.Start();
            }
        }

        private void BeginParse(string path)
        {
            if (settingsWindow.GetBackup())
                File.Copy(path, path + ".backup", true);

            string[] data = File.ReadAllLines(path);

            string from = settingsWindow.GetLangFrom();
            string to = settingsWindow.GetLangTo();

            var regex = new Regex("^[a-zA-Z0-9 ]*$");

            for (int i = 1; i < data.Length; i++)
            {
                circularProgressBar1.Value = (int)Math.Round((i / (float)data.Length) * 100);


                if (data[i].Length == 0)
                    continue;

                if (data[i].Trim()[0] == '#')
                    continue;

                if (!data[i].Contains('\"'))
                    continue;

                if (data[i].Contains("translate") && data[i].Split(' ')[0] == "translate")
                    continue;

                if (!data[i - 1].Contains('\"'))
                    continue;

                data[i - 1] = data[i - 1].Replace("\\\"", "");
                data[i] = data[i].Replace("\\\"", "");

                int index = 0;

                string[] line = data[i - 1].Split('\"');
                string text = string.Empty;
                if (line.Length == 3)
                {
                    index = 1;
                    text = line[index];
                }
                else if (line.Length == 5)
                {
                    index = 4;
                    text = line[index];

                    if (line[3].Length > 1)
                        continue;
                }

                string[] trLine = data[i].Split('\"');
                string trText = string.Empty;
                trText = trLine[index];

                if (trText != "")
                    continue;

                if (settingsWindow.GetTranslateEverything())
                {
                    trLine[index] = Translate(text, from, to);
                    if (settingsWindow.GetReverseTranslation())
                        trLine[index] = Translate(trLine[index], to, from);
                } else
                {
                    string[] words = text.Split(' ');
                    for (int w = 0; w < words.Length; w++)
                    {
                        if (words[w].Length < 5)
                            continue;

                        if (!regex.IsMatch(words[w]))
                            continue;

                        words[w] = Translate(words[w], from, to);
                    }

                    trLine[index] = string.Join(" ", words);
                }

                data[i] = string.Join("\"", trLine);

                SetText(data[i]);
            }

            File.WriteAllLines(path, data);
        }

        delegate void SetTextCallback(string t);

        public void SetText (string t)
        {
            if (this.dragText.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { t });
            }
            else
                dragText.Text = t;
        }

        public string Translate(string text, string from, string to)
        {
            if (text == "")
                return "";

            string page = null;
            try
            {
                WebClient wc = new WebClient();
                wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                wc.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                wc.Encoding = Encoding.UTF8;

                string url = string.Format(@"http://translate.google.com/m?hl=en&sl={0}&tl={1}&ie=UTF-8&prev=_m&q={2}",
                                            from, to, Uri.EscapeUriString(text));

                page = wc.DownloadString(url);
            }
            catch (Exception ex)
            { return "Translation Error =( " + ex.Message; }

            page = page.Remove(0, page.IndexOf("<div dir=\"ltr\" class=\"t0\">")).Replace("<div dir=\"ltr\" class=\"t0\">", "");
            int last = page.IndexOf("</div>");
            page = page.Remove(last, page.Length - last);

            return page;
        }

        private void hideButton_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        public static SettingsForm settingsWindow;

        private void settings_Click(object sender, EventArgs e) => settingsWindow.Visible = !settingsWindow.Visible;
    }
}
