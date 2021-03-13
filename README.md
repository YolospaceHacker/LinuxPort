# Yolospace Hacker Linux Port
Prepare YoloSpaceHacker Linux port
Build some CSharp Apps.
Test wine and steam proton commands and config.


# Setup Lab  

## Windows 

Visual Studio 
.Net 


## Linux 
Distro: ubuntu
We have choice between Wine or Steam



### Linux + Steam 

Steam rely on Proton an optimised version of wine

install ubuntu
install steam
sudo apr install steam

Launch Steam then enable beta 
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


# Test apps


## wine 



## steam 












