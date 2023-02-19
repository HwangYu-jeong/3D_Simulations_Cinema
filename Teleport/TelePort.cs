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
        //Player와 발판 사이의 거리 구함
        distance = Vector3.Distance(player.transform.position,
            cube.transform.position);

        if (distance <= 1f)
        {
            //타이머를 통해 다음 씬으로 넘어감
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
        // animTime동안 재생
        time += Time.deltaTime / animTime;
        // Image 컴포넌트의 색상 값 읽어오기
        Color color = fadeImage.color;
        // 알파 값 계산
        color.a = Mathf.Lerp(start, end, time);
        // 계산한 알파 값 다시 설정
        fadeImage.color = color;
    }
}
