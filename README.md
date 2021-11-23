## Getting Started

Make sure to install Unity 2019.4.28f1 via Unity Hub. This version of Unity specifically works with VRTK version 4. Also, make sure that blender is installed.

### Downloading the project

* Download this project repository to your local machine using *one* of the following methods:
  * Git clone the repository
  * Download the zip file and extract it

### Opening the downloaded project in the Unity software

> **Do not** drag and drop this downloaded project into an existing Unity project. The downloaded project **is a Unity project** already and you should not nest a Unity project inside another Unity project. Follow the instructions below for opening this tutorial project within the Unity software.

#### Using the Unity Hub

* Open the [Unity Hub] panel.
* Click the `Add` Button.
* Browse to the local directory where the repository was cloned/downloaded to and click `Select Folder`.
* The project will now show up in the Unity Hub project window, so select it to open the project in the Unity software.
* The project will now open within the Unity software.

### Running the game scene in your Quest 2

* Open the `Assets/Scenes/ScareCoOffices` scene.
* When you open the project, look towards the heiarchy on the left and check to see if "CameraRigs.UnityXR" is enabled and "CameraRigs.SpatialSimulator" is disabled (or vice versa if you want to only use the simulator and not the headset)
* Connect the VR headset into your laptop
* Make sure that your headset is enabled for developer mode. You can learn how to do it [here](https://developer.oculus.com/documentation/native/android/mobile-device-setup/)
* Allow for the computer connection in your VR Headset
* Make sure developer mode is on and USB conenction dialog is activate
* Under build settings, build for android platform. Make sure you see your VR Headset in the connections list
* Then click on Build and Run
* Now you should wait awhile until it is done uploading
* Go to your applications and in the select box in the upper right hand corner, select unauthorized applications. Select it and then open the app

