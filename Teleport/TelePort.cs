using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelePort : MonoBehaviour
{
    public GameObject player;
    public GameObject cube;
    private float distance;

    public float animTime = 2f;         
    public Image fadeImage;            
    private float start = 0f;          
    private float end = 1f;            
    private float time = 0f;

    private float timer = 0;

    private void Start()
    {
        
    }

    private void Update()
    {
        CheckNextScene();
    }

    private void CheckNextScene()
    {
        //Player�� ���� ������ �Ÿ� ����
        distance = Vector3.Distance(player.transform.position,
            cube.transform.position);

        if (distance <= 1f)
        {
            //Ÿ�̸Ӹ� ���� ���� ������ �Ѿ
            timer += Time.deltaTime;
            PlayFadeOut();
            if (timer > 2.0f)
            {
                SceneManager.LoadScene("Burning Cinema");
            }
        }
    }
    private void PlayFadeOut()
    {
        // animTime���� ���
        time += Time.deltaTime / animTime;
        // Image ������Ʈ�� ���� �� �о����
        Color color = fadeImage.color;
        // ���� �� ���
        color.a = Mathf.Lerp(start, end, time);
        // ����� ���� �� �ٽ� ����
        fadeImage.color = color;
    }
}
