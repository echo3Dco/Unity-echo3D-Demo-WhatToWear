# Unity-echo3D-Demo-WhatToWear
Do you have decision fatigue over what to wear in the morning? Let this app pick your clothes for you.

## Setup
* Built with Unity 2020.3.25.  _(Note: The echo3D Unity SDK is supported in 2020.3.25 and higher.)_
* Register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).
* [Add the Unity SDK](https://medium.com/r/?url=https%3A%2F%2Fdocs.echo3d.co%2Funity%2Finstallation). Troubleshoot [here](https://docs.echo3d.com/unity/troubleshooting#im-getting-a-newtonsoft.json.dll-error-in-unity).
* Clone this repo. 

## Setup

* [Add these models](https://docs.echo3D.co/quickstart/add-a-3d-model) to the echo3D console from the Unity Assets/Models folder:  <br>
      - Pants <br>
      - Top1 <br>
      - Top2 <br>
      - Top3 <br>
* Open the _SampleScene_ scene.
* [Set the API key](https://docs.echo3d.co/quickstart/access-the-console) and Entry IDs on the echo3D script using the Inspector for the objects.
![APIKeyandEntryId](https://user-images.githubusercontent.com/99516371/195749269-f7a43477-b67a-49e8-a212-6abdb9c948fd.png)<br>

* [Type your Secret Key](https://docs.echo3d.co/web-console/deliver-pages/security-page#secret-key) as the value for the parameter secKey in the file Packages/co.echo3D.unity/Runtime/Echo3DHologram.cs. _(Note: Secret Key only matters if you have the Security Key enabled). You can turn it off in the Security options in your echo3D console._
![NEWSecKey2](https://user-images.githubusercontent.com/99516371/195749308-b2349a3b-7e43-4d3c-8f09-fbfa9d3cb0be.png)<br>

* (Recommended) To move or edit the assets live in your project, check the boxes for “Editor Preview” and “Ignore Model Transforms”. At the top of your project, click Echo3D > Load Editor Holograms <br>
![EditorPreviewAndIgnoreModelTransforms](https://user-images.githubusercontent.com/99516371/195749348-dc0b06ad-efa6-4dbd-962f-0119b5c33ea0.png)<br>
![LoadHolograms](https://user-images.githubusercontent.com/99516371/195749354-b2295183-f877-444a-af22-ed87ffb17705.png) <br>


## Run
Press Play in Unity and hit Space to change tops.

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Screenshots
![ezgif com-gif-maker](https://user-images.githubusercontent.com/99516371/186972325-be4f646b-1383-4379-a9c6-db9e981f1c12.gif) <br>
![BlueTop](https://user-images.githubusercontent.com/99516371/186972348-5ddbe04f-a17b-4bb5-8e13-269f19fdbcc9.jpg) <br>
![GreenTop](https://user-images.githubusercontent.com/99516371/186972352-35dfe61d-2d51-4798-82f6-8e5786d4acc9.jpg) <br> <br>
![WhiteTop](https://user-images.githubusercontent.com/99516371/186972360-83dc352b-5894-4336-9445-731b62d93482.jpg) <br>
