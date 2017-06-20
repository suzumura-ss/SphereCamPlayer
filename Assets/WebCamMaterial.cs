using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamMaterial : MonoBehaviour {
    public int Width = 1920;
    public int Height = 1080;
    public int FPS = 30;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        var list = new List<WebCamDevice>(devices);
        int uc_index = list.FindIndex((WebCamDevice dev) => { return dev.name.EndsWith("UVC Capture"); });
        if (uc_index < 0)
        {
            uc_index = 0;
        }
        // display all cameras
        for (var i = 0; i < devices.Length; i++)
        {
            Debug.Log(devices[i].name);
        }
        WebCamTexture webcamTexture = new WebCamTexture(devices[uc_index].name, Width, Height, FPS);
        GetComponent<Renderer>().material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
}
