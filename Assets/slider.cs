using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    public Image Bar;
    public float progress;

    void start()
    {
        progress = 0;
        Bar.fillAmount = 0;
    }
    void Update () {
        if (progress >= 0.9f)
            start();
        Bar.fillAmount = progress;
        progress +=  0.001f;
    }
}
