# <p align="center">RedFox Smart Button</p>

## This package is no longer supported
I recommend using event triggers to achive the same result as this package provides.
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/script-EventTrigger.html

### Description

This package contains an extended version of the built-in Unity button. While the built-in Unity button is fine for the most common scenarios, it lacks some event types that buttons usually support.

Events like: Holding, Pressed, Released.

The package provides all three of these event types and some additional, just like Unity provides onClick event.

### Features
- Easy to use interface just like the traditional UI Button.
- **On Click**: Just like on the original button, sends the signal if the button release was over the button.
- **On Press**: Sends the signal after the button was pressed.
- **On Hold**: Sends signals while the button is held down.
- **On Release**: Sends the signal after the button was released (pointer was over the button when pushed, but release can be anywhere)
- **On Exit**: Sends the signal if the pointer leaves the button area.
- **On Enter**: Sends the signal if the pointer enters the button area.<br>
(Note: That onExit/onEnter is called despite no press or click happened because you still left/enter the button area.)

<p align="center"><img src="https://github.com/Menyus777/RedFox-Smart-Button/blob/develop/imgs/demonstration.gif" alt="Demonstration" width="575" height="525"></p>

### How to Install

1. Inside Unity click on Window > Package Manager
2. Inside Package Manager click on the + sign in the upper left corner
3. Choose "Add package from git URL..."
4. Paste the repository url into the text field<br> https://github.com/Menyus777/RedFox-Smart-Button.git

### How to Use

1. Add a button either by GameObject > UI > Button or GameObject > UI > Button - TextMeshPro
2. Click on your button in the hierarchy view and remove the button component.
3. Click on Add Component > RedFox UI > Smart Button
4. Add events just you would add onClick events :)

<p align="center"><img src="https://github.com/Menyus777/RedFox-Smart-Button/blob/develop/imgs/how-to-use.gif" alt="How to Use"></p>
