using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.Example.Handlers;

namespace Sedge_for_SipaaOS
{
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
        }

        ChromiumWebBrowser browser;

        public void InitializeChromium()
        {
            
        }

        private void Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
            CefSettings settings = new CefSettings();
            string filefolder = System.Reflection.Assembly.GetExecutingAssembly().Location;
            settings.CachePath = Path.GetDirectoryName(filefolder) + "Cache";
            browser = new ChromiumWebBrowser("google.com");
            guna2Panel1.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            browser.TitleChanged += Browser_TitleChanged;
            browser.AddressChanged += Browser_AddressChanged;
            browser.LoadingStateChanged += Browser_LoadingStateChanged;
            browser.LoadError += Browser_LoadError;
            Console.WriteLine("Executable folder : " + System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
           
            })); ;
        }

        private void Browser_LoadError(object sender, LoadErrorEventArgs e)
        {
            Console.Write("Chromium : A load error has been detected : " + e.ErrorText + " on the website " + e.FailedUrl);
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                guna2TextBox1.Text = e.Address;
            })); ;
        }

        private void Browser_TitleChanged(object sender, CefSharp.TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                this.Text = e.Title;
            })); ;
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                browser.Load(guna2TextBox1.Text);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            browser.Load(guna2TextBox1.Text);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
            {
                guna2Button1.Enabled = true;
            }
            else guna2Button1.Enabled = false;
            if (browser.CanGoForward)
            {
                guna2Button2.Enabled = true;
            }
            else guna2Button2.Enabled = false;
            browser.DownloadHandler = new DownloadHandler();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else panel1.Visible = true;
        }

        private void Ker(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.F12)
            {
                
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            browser.ShowDevToolsDocked(panel2, "devtools", DockStyle.Fill, 0, 0);
            panel2.Show();
        }
    }
}
