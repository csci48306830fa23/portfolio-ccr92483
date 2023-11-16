# Unity Utilities

*Anton Franzluebbers*

This is a collection of utility scripts and assets that I have created that are applicable to a variety of projects.
Also includes prefabs to quickly start a new project.

## Usage
Clone and use the package manager to add `package.json`, or add the git url to `Packages/manifest.json`.

## Scripts included

### `AdjustPos.cs`
Nudges an object with assignable keyboard shortcuts. Add this script to the object, then customize the inputs in the editor.

### `InputMan.cs`
Makes input from VR devices accessible from a unified set of methods. Can treat axes as button down. Needs an InputModule to work, so either add the default one with the button in the editor, or add a platform-specific one.

### `Logger.cs`
Logs any data to a file.

### `CopyTransform.cs`
One object copies the position and/or rotation of another using a variety of techniques. Global or local offsets can be set.

### `SaveLoc.cs`
Saves the location and rotation of an object to playerprefs. Local or global coordinates.

### `Movement.cs`
Adds several movement techniques while maintaining compatibility with many rig setups.
Techniques supported:
 - Teleporting
 - Hand movement (Echo style)
 - Translational gain

### `Editor/SetupVRInput.cs`
Adds a dropdown menu option for automatically populating the Input system for use with the InputMan script for use with a VR device.

### `Editor/EditorShortcutKeys.cs`
Adds `F5` shortcut to enter play mode.

### `ControllerHelp.cs` and `ControllerHelpTester.cs`
Adds functionality to highlight controller buttons and show hints. To use, add the `ControllerHelp` prefab found in the `Prefabs` folder to the scene anywhere. Highlighting inputs can be done by calling the static method `ControllerHelp.ShowHint()` and passing in a message.

### `DontDestroyOnLoad.cs`
That's it

### `Rig.cs`
Basically a data structure for VR rigs.

### `VRObject.cs`
Track an Oculus VRObject


## Interaction Scripts

### `PointForceGrabbable.cs`
A versatile grab script that can work for positional dials and general physics grabbing.


## TODO
 - Teleport line shader doesn't compile with build by default
### brook requests
 - Prefab: Rig->Right Hand and Rig->Left Hand are missing a script
