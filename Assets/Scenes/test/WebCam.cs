using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Web�J����
public class WebCam : MonoBehaviour
{
    private static int INPUT_SIZE = 1024;
    private static int FPS = 30;

    // UI
    RawImage rawImage;
    WebCamTexture webCamTexture;

    // �X�^�[�g���ɌĂ΂��
    void Start()
    {
        // Web�J�����̊J�n
        this.rawImage = GetComponent<RawImage>();
        this.webCamTexture = new WebCamTexture(INPUT_SIZE, INPUT_SIZE, FPS);
        this.rawImage.texture = this.webCamTexture;
        this.webCamTexture.Play();
    }
}
