# Watson-text-to-speech-demo

> This is a WPF Application that calls the Watson Text to Speech service via Node-RED in order to convert a written text to a .wav file that is streamed on the client's browser. 

In order to ensure the correct functioning of the application, you need a IBM Cloud account with the following services: 

- A Node-RED instance 
- A Watson Text to Speech service instance. 

You can easily create these services using your Lite Plan. Just go to the IBM Cloud Catalog. For the Node-RED instance, go to the Boilerplates section and click here: 


![Node-RED Catalog](https://github.com/GuidoRocco/Watson-text-to-speech-demo/blob/master/images/Picture_1.png) 



An intuitive process will guide you to the setting of an acount (if you don't have one). 
For the Watson Text to Speech service, just go to the Watson section here: 


![Watson Text to Speech Catalog](https://github.com/GuidoRocco/Watson-text-to-speech-demo/blob/master/images/Picture_2.png) 


If you click on Watson Text to Speech, the browser will guide you to the intuitive setting of the service. You can look at your credentials in the "Manage" section, where you can retrieve (or generate) the credentials that will allow you to call the service remotely. 


![Watson Text to Speech Credentials](https://github.com/GuidoRocco/Watson-text-to-speech-demo/blob/master/images/Picture_3.png) 


The application will call the Watson Text to Speech Service via Node-RED. Let us at first configure the server side of the application.  First of all, you have to configure the Node-RED flow in order to accept the HTTP Get Request and return the speech as the response. 
You will import the clipboard in the folder Node-RED_clip of the repository into your Node-RED. 
Click on Import on the Node-RED Menu and select Import Clipboard. 


![Node-RED](https://github.com/GuidoRocco/Watson-text-to-speech-demo/blob/master/images/Picture_4.png) 


Copy the content of the node file (in Node-RED_clip) into the textbox of the Import Clipboard. You will obtain the following flow. 

![Node-RED Flow](https://github.com/GuidoRocco/Watson-text-to-speech-demo/blob/master/images/Picture_5.png) 

In the Watson Text to Speech Node, insert the credentials of your Watson Text to Speech Service in order to connect the service. Then, click on "Deploy" in your Node-RED Editor to complete the configuration of the server side of the application. 


![Node-RED Watson Credentials](https://github.com/GuidoRocco/Watson-text-to-speech-demo/blob/master/images/Picture_6.png) 






