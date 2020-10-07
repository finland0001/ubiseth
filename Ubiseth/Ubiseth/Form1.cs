using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Ubiseth
{
    public partial class Form1 : Form
    {
        public static Mem m = new Mem();
        private static void writeMem(object sender, string opcode, string enable, string disable)
        {
            if (((CheckBox)sender).Checked == false)
            {

                //  writeMem(checkBox1, "2B3B1E", "0x90 0x90", "0x75 0x0C");
                m.writeMemory("Growtopia.exe+" + opcode, "bytes", disable);
            }
            else
            {

                m.writeMemory("Growtopia.exe+" + opcode, "bytes", enable);
            }

        }
        public Form1()
        {
     
            InitializeComponent();
          
        }
   
        private void setBorderColors(Color col)
        {
            bottom.BackColor = col;
            up.BackColor = col;
            left.BackColor = col;
            right.BackColor = col;
         //   tabControl.SelectedTab = col;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

   
            settings.Shifty = Color.Red;

        }
       
     
        
        
        public static int ghp { get; set; }
        [DllImport("shlwapi.dll")]
        public static extern int ColorHLSToRGB(int H, int L, int S);
        private void rainbow_Tick(object sender, EventArgs e)
        {
       
            if (ghp == 240)
            {
                ghp = 0;
            }
            else
            {
                ghp++;


                
               settings.Shifty = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
             
                this.ForeColor = settings.Shifty;
                setBorderColors(settings.Shifty);
                title.ForeColor = settings.Shifty;
                closeForm.ForeColor = settings.Shifty;
               txtSpeed.ForeColor = Ubiseth.settings.Shifty;
               txtPet.ForeColor = Ubiseth.settings.Shifty;
          
  
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

  
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void titleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void up_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            closeForm.BackColor = Color.FromArgb(55, 55, 55);
            closePanel.BackColor = Color.FromArgb(55, 55, 55);

        }

        private void closeForm_MouseLeave(object sender, EventArgs e)
        {
            closeForm.BackColor = Color.FromArgb(36, 36, 36);
            closePanel.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void closePanel_MouseEnter(object sender, EventArgs e)
        {
            closeForm.BackColor = Color.FromArgb(55, 55, 55);
            closePanel.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void closePanel_MouseLeave(object sender, EventArgs e)
        {
            closeForm.BackColor = Color.FromArgb(36, 36, 36);
            closePanel.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void closePanel_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        private static Process GetProcessByHandle(IntPtr hwnd)
        {
            try
            {
                uint processID;
                GetWindowThreadProcessId(hwnd, out processID);
                return Process.GetProcessById((int)processID);
            }
            catch { return null; }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        private static Process GetActiveProcess()
        {
            IntPtr hwnd = GetForegroundWindow();
            return hwnd != null ? GetProcessByHandle(hwnd) : null;
        }
        bool canApply = false;
        private IntPtr ProcessHandle = IntPtr.Zero;
        bool openprocess = false;
        private void attachProcess_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("growtopia");
            if (pname.Length == 0)
            {
                
                ProcessLabel.Text = "Growtopia is not running!";
                openprocess = false;
            }
            else
            {
                if (!openprocess)
                {
                    int pID = m.getProcIDFromName("Growtopia");

                    m.OpenProcess(pID);
                    float ver = m.readFloat("Growtopia.exe+44B9A0");

                    string versionstring = ver.ToString();

                    if (versionstring != settings.gtVer)
                    {
                        MessageBox.Show("Your GT version is wrong version! Please change it. This trainer is made for 3.022 only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ProcessLabel.ForeColor = Color.Red;
                        ProcessLabel.Text = "Wrong GT version, please get 3.022 and restart this trainer.";
                        attachProcess.Stop();
                    }
                    else
                    {

                        m.writeMemory("Growtopia.exe+1E005E", "bytes", "0x90 0x90");
                    }
                    }
              
                
                
                Process currentProcess = GetActiveProcess();

                ProcessLabel.Text = "Growtopia is running (Not focused)";
           
                if (currentProcess != null)
                {
                    if (currentProcess.MainWindowTitle == settings.processtitle)
                    {
                        ProcessLabel.Text = "Growtopia running (Focused)";

           
                    }
                }
            }




        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        static string numberOnly = "";
       public static int toInt(string s)
        {


             numberOnly = Regex.Replace(s, "[^0-9.]", "");
          
            int jee = Int16.Parse(numberOnly);
            return jee;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
             
                if (toInt(txtSpeed.Text) < 101)
                {
                    rainbow.Interval = toInt(txtSpeed.Text);
                }
            }
            catch (Exception)
            {
                return;
            }
        
            }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.Form.ActiveForm.Opacity = ((double)(trackOpacity.Value) / 100.0);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                int temp = trackBar1.Value;
                string hex = temp.ToString("X");
                byte b = Convert.ToByte(hex, 16);
                m.writeMemory("Growtopia.exe+327CB4", "bytes", "BA " + b.ToString() + " 00 00 00");
                dispwPart.Text = "Value: " + trackBar1.Value.ToString();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            writeMem(checkBox8, "327C5F", "90 90", "75 79");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.writeMemory("Growtopia.exe+0x00547FD8,0x8,0x16E0", "int", txtPet.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
 
   
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            tabControl.BackColor = Color.White;
            tabPage1.BackColor = Color.White;
            tabPage2.BackColor = Color.White;
            tabPage3.BackColor = Color.White;
            tabPage4.BackColor = Color.White;
            tabPage5.BackColor = Color.White;
            txtSpeed.BackColor = Color.White;
        }
        //Growtopia.exe+132F54 - 75 13                 - jne Growtopia.exe+132F69

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            writeMem(checkBox7, "132F54", "90 90", "75 13");
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
          
        }

        private void trackBar2_ValueChanged_1(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {

                int temp = trackBar2.Value;
                string hex = temp.ToString("X");
                byte b = Convert.ToByte(hex, 16);
                //Growtopia.exe+132F5A - B9 05000000           - mov ecx,00000005 { 5 }

                m.writeMemory("Growtopia.exe+132F5A", "bytes", "B9 " + b.ToString() + " 00 00 00");
                label6.Text = "Value: " + trackBar2.Value.ToString();
            }
        }
    }
    }

