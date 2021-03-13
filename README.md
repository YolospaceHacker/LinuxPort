# Yolospace Hacker Linux Port


The goal of this repo is to prepare YoloSpaceHacker Linux port.

Build some CSharp Apps.
Test wine and steam proton commands and config.


# Setup Lab  

## Windows 

Visual Studio 
.Net 


## Linux 
Distro: ubuntu


### Linux + Steam 

Steam rely on Proton an optimised version of wine

install ubuntu
install steam
sudo apt install steam

Launch Steam /parameters / enable proton 

Install Yolo
Launch with Steam 

Starts, then Exeception on Cef Dll load:
[ERROR] FATAL UNHANDLED EXCEPTION: System.IO.FileNotFoundException: Could not load file or assembly 'CefSharp.Core, Version=86.0.240.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138' or one of its dependencies.

=> or one of its dependencies


#### Manual Launch

$ mkdir ~/.proton
$ STEAM_COMPAT_DATA_PATH=~/.proton/ ~/.steam/steam/steamapps/common/Proton\ -\ Experimental/proton run .steam/debian-installation/steamapps/common/Yolo\ Space\ Hacker\ -\ Mission\ Bikini/bin/HackOut.exe


$ PROTON_DUMP_DEBUG_COMMANDS=1 STEAM_COMPAT_DATA_PATH=~/.proton/ ~/.steam/steam/steamapps/common/Proton\ -\ Experimental/proton run ./CefSharp.WinForms.Example.exe
[x] g_proton.wine_bin: /home/yolo/.steam/steam/steamapps/common/Proton - Experimental/dist/bin/wine

['./CefSharp.WinForms.Example.exe']
[x] self.cmdlineappend: 
[]
Wine cannot find the FreeType font library.  To enable Wine to
use TrueType fonts please install a version of FreeType greater than
or equal to 2.0.5.
http://www.freetype.org

Unhandled Exception:
System.IO.FileNotFoundException: Could not load file or assembly 'CefSharp.Core, Version=86.0.240.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138' or one of its dependencies.
File name: 'CefSharp.Core, Version=86.0.240.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138'
[ERROR] FATAL UNHANDLED EXCEPTION: System.IO.FileNotFoundException: Could not load file or assembly 'CefSharp.Core, Version=86.0.240.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138' or one of its dependencies.

=> or one of its dependencies.
Precharger les dll dans le jeu...



### Linux + wine 

Install Visual Studio Dll an d.net thanks to winetricks 

WINEDEBUG="-all" PROTON_NO_ESYNC=1 PROTON_DUMP_DEBUG_COMMANDS=1 STEAM_COMPAT_DATA_PATH="/home/yolo/.wine" "/home/yolo/.steam/steam/steamapps/common/Proton - Experimental/proton" run ./HackOut.exe




# Build windows apps 

## Windows .Net .exe 


## Windows .Net Form .exe 


## Windows CefSharp Form .exe 

windows:
Step 1: 
Start, then list Loaded Dlls
Copy the dll.

Step 2:
Pre-load Dlls


# Test apps


## wine 



## steam 




##### CSharp code snipet

 // List loaded dlls
            Process[] processes = null;
            int processID;
            if (myConfig.GetEntryBool("debug", "linuxtarget", "false"))
            {
                Console.WriteLine("[+] Dump loaded Dlld\n");
                processID = Process.GetCurrentProcess().Id;
                processes = Process.GetProcesses();
                foreach (Process process in processes)
                {
                    if (process.Id == processID)
                    {
                        TT("PID:  " + process.Id);
                        TT("Name: " + process.ProcessName);
                        TT("Modules: ");

                        foreach (ProcessModule module in process.Modules)
                        {
                            TT(module.FileName);
                        }
                    }
                }
                TT("\n");

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
                    HELogs.Instance.Log("Dll preload: " + dll, HELogs.Level.info);
                    TT("Dll preload: " + dll);
                    LoadLibraryA(dll);
                }
                TT("Dll preload: Done");
            }









