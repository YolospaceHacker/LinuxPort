using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpForms
{
    public partial class Form1 : Form
    {
        string appDir = "";
        public Form1()
        {
            InitializeComponent();
            //
            // Set App directory based on exe path & remove /bin/
            string binDir = AppDomain.CurrentDomain.BaseDirectory; //Environment.CurrentDirectory;
            DirectoryInfo parentDir = Directory.GetParent(binDir);
            appDir = parentDir.Parent.FullName;
        }

        void TT(string txt)
        {
            rtbLog.Text += txt;
        }

        public void  DumpLoadedDllList()
        {
            // List loaded dlls
            Process[] processes = null;
            int processID;
    
            Console.WriteLine("[+] Dump loaded Dlld\n");
            processID = Process.GetCurrentProcess().Id;
            processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.Id == processID)
                {
                    TT("PID:  " + process.Id+"\n");
                    TT("Name: " + process.ProcessName+"\n");
                    TT("Modules: ");

                    foreach (ProcessModule module in process.Modules)
                    {
                        TT(module.FileName+"\n");
                    }
                    TT("======\n\n");
                }
            }
            TT("\n");

        }

        [DllImport("kernel32.dll")]
        static extern bool LoadLibraryA(string hModule);

        void PreLoadDlls()
        {
            // Pre load Dlls
            List<string> Dlls = new List<string>()
                {
                    "CefSharp.Core.dll",
                    "cfgmgr32.dll",
                    "chrome_elf.dll",
                    "coloradapterclient.dll",
                    "comdlg32.dll",
                    "credui.dll",
                    "cryptui.dll",
                    "d3d9.dll",
                    "dbghelp.dll",
                    "devobj.dll",
                    "dwmapi.dll",
                    "dxva2.dll",
                    "hid.dll",
                    "icm32.dll",
                    "iertutil.dll",
                    "libcef.dll",
                    "MMDevAPI.dll",
                    "mscms.dll",
                    "msvcp140.dll",
                    "netapi32.dll",
                    "netutils.dll",
                    "nlaapi.dll",
                    "oleacc.dll",
                    "propsys.dll",
                    "samcli.dll",
                    "urlmon.dll",
                    "vcruntime140.dll",
                    "winmm.dll",
                    "winspool.drv",
                    "winsta.dll",
                    "wtsapi32.dll",
                };
            var files = Directory.EnumerateFiles(appDir + @"\linux\dll\", "*.dll", SearchOption.AllDirectories);
            foreach (string dll in files)
            {
                //var DLL = Assembly.LoadFile(dll);
                TT("Dll preload: " + dll);
                LoadLibraryA(dll);
            }
            TT("Dll preload: Done");
        }
        private void bClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bListDlls_Click(object sender, EventArgs e)
        {
            DumpLoadedDllList();
        }
    }
}
