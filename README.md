HoloAssetBundle
========================

[![My Telegram](https://img.shields.io/badge/Telegram-%40D__o__r__G-blue)](https://t.me/D_o_r_G)
##### What was used: #####
***
  - [![Unity Version](https://img.shields.io/badge/unity-2018.4.21-blue.svg)](https://unity3d.com/get-unity/download)
  - [![MRTK Version](https://img.shields.io/badge/Microsoft-MRTK%202.4.0-green)](https://github.com/microsoft/MixedRealityToolkit-Unity/releases/tag/v2.4.0)
  - Hololens 1st gen.
  - Magic
##### Installation instruction: #####
***
- Open the project in Unity; 
- Bild visual studio solution;
- Deploy on Hololens.
> If you get "Windows Mobile" error while building your project, in the solution folder, open HoloMapOnline> HoloMapOnline.vcxproj. At the end of the file, cut out the mention of Windows Mobile.

##### Modifying models instruction: #####
***
- Open Assets/Resources/3dmodel prefab and change the sphere to yours model; 
- Resize the box collider on 3dmodel to fit your model;
- Bild asset Bundle. Assets Bundle > WSA;
- Upload the file (model) to the server in binary mode. 
> You can change the name of the 3d model from the bundle in Loader > Laod Asset. Later I will add the ability to change the name of the models in real-time on Hololens.

[test video](https://www.dropbox.com/s/37m3q6syf62ih9a/AssetBundle.mp4?dl=0)


