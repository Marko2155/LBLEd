# LBLEd
Line-by-line Editor - Made in Vanilla C#

# How to compile
Follow the instructions on my [BASIC#](https://github.com/marko2155/basicsharp#how-to-compile) repo, here.

# Installation guide
If you want to install this for _actual_ use, here you go.
Anything in bold means it has to be done on either Linux or Mac. The steps in bold cannot be completed on Windows.

:0
Install [Mono](https://mono-project.com)
Use ```brew``` for Linux or Mac.

:1
Download the latest release.

:2
Create a folder on your Desktop called "SH".
Move LBLEd.exe to that folder.
**Make a file in that folder called "lbled" (shortcut to Mono running lbled.exe)**
**In there, write**
```
mono lbled.exe
```
**Now, go over to ~ (user folder), open your .zshrc file, find your $PATH variable and make sure it is set to this:**
<img width="801" alt="Screenshot 2023-12-18 at 3 02 43 PM" src="https://github.com/Marko2155/LBLEd/assets/98662057/2ade20a4-cb00-4db7-814d-6d4bd1ca6d38">

:2.5
For Windows users, just add the SH folder to your environment variables.

:3
Now, to test it, restart your terminal (or Command Prompt on Windows), then type ```lbled```. If nothing appears, hooray! You can now use LBLEd anywhere you want! (until you delete the SH folder).

# Tutorial

Welcome to LBLEd!

When you start LBLEd, type in whatever you want put into the file.
Then, press enter, and type
```?w test``` to save it to file.
Then, do ```?q```.
Or, just ```?wq test```.
When you want to quit, do ```?q```.

Make sure you don't do this while writing though, LBLEd will remind you to save.
If you don't want to save, just type ```?qa``` (standing for Quit Anyway).

Now, write 5 lines of gibberish.
Example:
```
sdfghdgfhs
fdghdfghdfgh
dfghdfg
hdfghdfgh
dfgh
```
Now, remember that last line.
Type ```?dll``` (stands for Delete last line).
Now, do a Write-quit.
Congrats, you just deleted a line from your file!

