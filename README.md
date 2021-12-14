![header-bdk](https://user-images.githubusercontent.com/48277920/145983130-52739f63-b2da-4856-971b-6d05e43008af.png)

# Bouvet Development Kit

The Bouvet Development Kit (BDK) package allows you to easily create applications for the Hololens 2 using Unity Software.

## Supported version

 | [![windows](https://user-images.githubusercontent.com/48277920/145994942-b90d9c8a-60b3-444f-abbd-673434ce6096.png)](https://developer.microsoft.com/windows/downloads/windows-10-sdk) [<p align="center">Windows SDK</p>](https://developer.microsoft.com/windows/downloads/windows-10-sdk)| [![unity](https://user-images.githubusercontent.com/48277920/145994938-f3637380-5050-45b1-a35a-2054229b535e.png#gh-dark-mode-only)](https://unity3d.com/get-unity/download/archive#gh-dark-mode-only) [![unity](https://user-images.githubusercontent.com/48277920/146033376-10fa0548-866a-4933-ae98-bb7908ebce42.png#gh-light-mode-only)](https://unity3d.com/get-unity/download/archive#gh-light-mode-only)  [<p align="center">Unity 2020 LTS</p>](https://unity3d.com/get-unity/download/archive)| [![visualstudio](https://user-images.githubusercontent.com/48277920/145994943-eb8bbddc-7b97-4c0e-87d7-129181387c43.png)](http://dev.windows.com/downloads) [<p align="center">Visual Studio 2019</p>](http://dev.windows.com/downloads)| 
| :--- | :--- | :--- | 

BDK has only been tested with the following versions of Unity and Visual studio so far. There are plans to move to Unity 2021 once it enters LTS, using 2021 is on your own risk.

Please refer to the [Install the tools](https://docs.microsoft.com/en-us/windows/mixed-reality/develop/install-the-tools) page for more detailed information.

## Quick guide

### Installation via Git in UPM

Open the Unity package manager and navigate to *"Add package from git URL..."*

 <!-- Add image for add from git thing -->

![Package Manager > + > add from Git URL](../../wiki/images/upm-git-add.PNG)

Supply the following URL:

`https://github.com/bouvet/BouvetDevelopmentKit.git`

### Setup project settings

1. Go to build settings `(Ctrl + Shift + B)` and switch to the Universal Windows Platform. Then set target device to HoloLens and target architecture to ARM64.

2. Next go into Player Settings and under Other settings there is a setting called `Active Input Handlig` that should be set to `Input System Package (New)`.

3. Finally, you need to go to the `XR Plug-in Management` tab in the Player Settings and enable `Windows Mixed Reality`.

### Create your scene

To start creating with BDK, you need to add the `BDK Hololens 2 Prefab` ([read more](../../wiki/BDK-Hololens-2-Prefab)) to your scene. You can find it by searching in the packages folder. Next find the `InputManager` game object in the hirarchy of the prefab and enable the input options you wnt to use. We usually use at least `Use Hand Tracking`, `Allow Manipulation`, and `Use Interaction Beams`.

Now you can add some object to your scene and add the `Grabbable`, `Two-Hand-Grabbable`, or `Interactable` scripts to them to start adding in functionality to your project. You can also go to [Samples](../../wiki/samples) and add BDK Essentials to find a few nifty menus and buttons.

### Building for the HoloLens 2

To build your app, click the `build` button in build settings and create a new folder for build output. This will generate a visual Studio solution that you can use to deploy your project. for more info on this see Microsoft's own [guide](https://docs.microsoft.com/en-us/windows/mixed-reality/develop/advanced-concepts/using-visual-studio?tabs=hl2).

Set configuration to release, platform to ARM 64 and run on Device

Connect your Hololens to the PC and go to Debug > Start without debugging
	Visual studio will now build and run your project on the hololens
	
You might have to Set your hololens to developer mode and get a PIN code from it to allow building and running.
	
for more detailed information on building from visual studio, see: https://docs.microsoft.com/en-us/windows/mixed-reality/develop/advanced-concepts/using-visual-studio?tabs=hl2

Note, some settings might differ between MRTK and BDK here. chack out this README, the wiki, or ask(issue?, discord?, slack?) if there is anything you are wondering about

## Documentation

BDK documentation is split into 2 categories, Guide and Advanced. The guide is for how to use BDK for you projects, Advanced wiki is a guide on how BDK works and how you can help us develope BDK further.

<a href="https://github.com/bouvet/BouvetDevelopmentKit/wiki">
	<img align="left" width="380" alt="Qries" src="https://user-images.githubusercontent.com/48277920/146026260-7b28d6c9-99de-4239-8425-1719da2d456f.png">
</a>
<a href="https://github.com/bouvet/BouvetDevelopmentKit/wiki/Architecture">
	<img align="right" width="380" alt="Qries" src="https://user-images.githubusercontent.com/48277920/146026256-5919dcbb-9293-471e-a88c-9cbdc497206d.png">
</a>

<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>

## Functionalities
<img align="right" width="300" src="https://user-images.githubusercontent.com/48277920/146011970-e987037c-7cf9-4a06-9fcd-55cd8e50ec90.png#gh-dark-mode-only" />
<img align="right" width="300" src="https://user-images.githubusercontent.com/48277920/146035405-1fc300a3-c5d0-4644-bd27-500f93f75b86.png#gh-light-mode-only" />

<br/>

[![swipe_down_black_24dp 1](https://user-images.githubusercontent.com/48277920/146013190-6acbf0be-eba3-489c-a1cc-3421fd055d6c.png)](#)[Hand interaction](https://github.com/bouvet/BouvetDevelopmentKit/wiki)

[![gps_not_fixed_black_24dp 1](https://user-images.githubusercontent.com/48277920/146013189-2664fa7d-9ad7-4073-82a5-78b5510bd9f6.png)](#)[Head Gaze interaction](https://github.com/bouvet/BouvetDevelopmentKit/wiki)

[![visibility_black_24dp 1](https://user-images.githubusercontent.com/48277920/146013187-c8325371-1f12-470e-8ceb-5e80af3d7d5b.png)](#)[Eye Gaze interaction](https://github.com/bouvet/BouvetDevelopmentKit/wiki)

[![area_chart_black_24dp 1](https://user-images.githubusercontent.com/48277920/146013183-80c68707-0e4a-49ec-bf7a-9476068966a9.png)](#)[Spatial Mapping](https://github.com/bouvet/BouvetDevelopmentKit/wiki)

[![record_voice_over_black_24dp 1](https://user-images.githubusercontent.com/48277920/146013181-a657e414-e80f-4a03-bf5f-02a31f2c4347.png)](#)[Voice commands](https://github.com/bouvet/BouvetDevelopmentKit/wiki)

[![history_edu_black_24dp 1](https://user-images.githubusercontent.com/48277920/146013179-d95dd37a-fa3e-4f20-82f5-47017eaf92e0.png)](#)[BDK Logger](https://github.com/bouvet/BouvetDevelopmentKit/wiki)

[![gradient_black_24dp 1](https://user-images.githubusercontent.com/48277920/146013192-07500820-d867-497f-8f85-c5e325bac23c.png)](#)[Optimized shader](https://github.com/bouvet/BouvetDevelopmentKit/wiki)

[![palette_black_24dp 2](https://user-images.githubusercontent.com/48277920/146013191-5ee14c8e-5a94-4b98-b7b0-1a5b6660e06a.png)](#)[Color profile](https://github.com/bouvet/BouvetDevelopmentKit/wiki)

<br/>
<br/>

## Samples

|  [![Floating Menu](https://raw.githubusercontent.com/wiki/bouvet/BouvetDevelopmentKit/images/FloatingMenu-68392d27-3a64-4991-9a86-556ea663d012.gif)](https://github.com/bouvet/BouvetDevelopmentKit/wiki/Essentials#floating-menu) [Floating Menu](https://github.com/bouvet/BouvetDevelopmentKit/wiki/Essentials#floating-menu) | [![Hand Menu](https://raw.githubusercontent.com/wiki/bouvet/BouvetDevelopmentKit/images/HandMenu-0e2d0190-3133-4858-a12d-5eb4af83ca19.gif)](https://github.com/bouvet/BouvetDevelopmentKit/wiki/Essentials#hand-menu) [Hand Menu](https://github.com/bouvet/BouvetDevelopmentKit/wiki/Essentials#hand-menu) |
| :--- | :--- |
| The floating menu is a type of panel that can hold any content or menu. | The hand menu is another common and simple menu. 
|  [![Clock Menu](https://raw.githubusercontent.com/wiki/bouvet/BouvetDevelopmentKit/images/ClockMenu-ba557c09-22ce-4855-a07c-832121c4bfca.gif)](https://github.com/bouvet/BouvetDevelopmentKit/wiki/Essentials#clock-menu) [Clock Menu](https://github.com/bouvet/BouvetDevelopmentKit/wiki/Essentials#clock-menu) | [![Drape Menu](https://raw.githubusercontent.com/wiki/bouvet/BouvetDevelopmentKit/images/DrapeMenu-6b4538d3-7904-4b38-a240-de784817cb5e.gif)](https://github.com/bouvet/BouvetDevelopmentKit/wiki/Essentials#drape-menu) [Drape Menu](https://github.com/bouvet/BouvetDevelopmentKit/wiki/Essentials#drape-menu) |
| The clock menu prefab is an example of a menu that appears where a watch would normally be. | The drape menu is a menu that is attached to the left hand and can be accessed by pulling on a tab. |

## Apps made with BDK
<a href="https://www.bouvet.no/vi-jobber-med/hololens/copal">
	<img align="left" width="450" src="https://user-images.githubusercontent.com/48277920/146021159-35507ce1-ab8f-4c42-8f7e-c88fbef3c81b.png" />
</a>
<a href="https://www.bouvet.no/vi-jobber-med/hololens/copal">
	<img align="left" width="250" src="https://user-images.githubusercontent.com/48277920/146020272-3a031c76-c755-4015-a54a-b23c77e28935.png" />
</a>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
Copal is not only an app for HoloLens 2, it is a concept. We in Bouvet can make customized app based on existing and new technologies.
<a href="https://www.joinlens.com/">
	<img align="left" width="450" src="https://user-images.githubusercontent.com/48277920/146021174-7f0d5234-3327-4205-82ca-dda50c313d9b.png" />
</a>
<a href="https://www.joinlens.com/">
	<img align="left" width="250" src="https://user-images.githubusercontent.com/48277920/146021165-1525832c-755b-433c-ba4e-349e8c479c2c.png" />
</a>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
Lens is an innovative communication solution made for Microsoft HoloLens 1 and 2. It brings a new dimension to industrial communication utilizing the power of HD video built into the HoloLens. 
<a href="https://wayfinder-dashboard.azurewebsites.net/">
	<img align="left" width="450" src="https://user-images.githubusercontent.com/48277920/146021172-95e4601c-70d7-4d87-a71a-e12b36260efc.png" />
</a>
<a href="https://wayfinder-dashboard.azurewebsites.net/">
	<img align="left" width="250" src="https://user-images.githubusercontent.com/48277920/146021163-2a4c12e7-1667-4d28-a0f2-bc5ded9a898f.png" />
</a>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
Wayfinder by bouvet is an app that lets you navigate with your smartphone using advanced 
technology like Azure Apatial Anchors.
