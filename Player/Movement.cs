using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float animTime = 3f;          

    public Image fadeImage;            

    private float start = 0f;          
    private float end = 1f;            
    private float time = 0f;
    private float checkTimer = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("Cinema Lobby");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Application.Quit();
        }
    }

    void PlayFadeOut()
    {
        time += Time.deltaTime / animTime;
        Color color = fadeImage.color;
        color.a = Mathf.Lerp(start, end, time);
        fadeImage.color = color;
    }
}
