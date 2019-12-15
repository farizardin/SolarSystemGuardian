using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTexture : MonoBehaviour
{
    static WebCamTexture webcamTexture;

    void Start()
    {
        if(webcamTexture == null)
            webcamTexture = new WebCamTexture();

        webcamTexture.Play();
        Renderer renderer = GetComponent<Renderer>();

        if (webcamTexture.isPlaying)
            renderer.material.mainTexture = webcamTexture;
    }
    /*
    void OnGUI()
    {
        if (webcamTexture.isPlaying)
            if (GUILayout.Button("Stop"))
                webcamTexture.Stop();
    }
    */
    public static void OnCameraStop()
    {
        if (webcamTexture.isPlaying)
            webcamTexture.Stop();
    }
}
