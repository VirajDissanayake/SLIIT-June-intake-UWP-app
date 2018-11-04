﻿using DotNetBrowser;
using DotNetBrowser.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.BrowserContextSample
{
    public partial class Form1 : Form
    {
        Browser browserOne;
        BrowserView browserViewOne;

        Browser browserTwo;
        BrowserView browserViewTwo;


        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This Browser instance will store cookies and user data files in "user-data-dir-one" dir.
                        
            String browserOneUserDataDir = Path.GetFullPath("user-data-dir-one");
            Directory.CreateDirectory(browserOneUserDataDir);
            browserOne = BrowserFactory.Create(new BrowserContext(new BrowserContextParams(browserOneUserDataDir)));
            browserViewOne = new WinFormsBrowserView(browserOne);
            browserOne.LoadURL("teamdev.com");
            splitContainer1.Panel1.Controls.Add((Control)browserViewOne);

            // This Browser instance will store cookies and user data files in "user-data-dir-two" dir.
            String browserTwoUserDataDir = Path.GetFullPath("user-data-dir-two");
            Directory.CreateDirectory(browserTwoUserDataDir);
            browserTwo = BrowserFactory.Create(new BrowserContext(new BrowserContextParams(browserTwoUserDataDir)));
            browserViewTwo = new WinFormsBrowserView(browserTwo);
            browserTwo.LoadURL("google.com");
            splitContainer1.Panel2.Controls.Add((Control)browserViewTwo);

            // The browserOne and browserTwo will not see the cookies and cache data files of each other.
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!browserViewOne.IsDisposed)
            {                
                browserOne.Dispose();
                browserViewOne.Browser.Dispose();
				browserViewOne.Dispose();
            }

            if (!browserViewTwo.IsDisposed)
            {                
                browserTwo.Dispose();
                browserViewTwo.Browser.Dispose();
				browserViewTwo.Dispose();
            }
        }
    }
}
