using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject btnleft;
    public GameObject btnright;
    public GameObject btnup;
    public GameObject btndown;

    public int count = 0;

    public bool check = true;
    void Start()
    {
        btnleft = GameObject.Find("btnleft");
        btnright = GameObject.Find("btnright");
        btnup = GameObject.Find("btnup");
        btndown = GameObject.Find("btndown");
    }


    public void Restart()
    {
        SceneManager.LoadScene("Mission UI");
    }
    public void Pass()
    {
        SceneManager.LoadScene("Extinguisher Scene");
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.A))
            {
                btnleft.SetActive(false);
                if (count == 2)
                {
                    count++;
                    check = true;
                }
                else check = false;

                
            }

            else if (Input.GetKeyDown(KeyCode.D))
            {
                btnright.SetActive(false);

                if (count == 1)
                {
                    count++;
                    check = true;
                }
                else check = false;

                
            }

            else if (Input.GetKeyDown(KeyCode.W))
            {

                btnup.SetActive(false);
                if (count == 0)
                {
                    count++;
                    check = true;
                Debug.Log(count);
            }
                else check = false;

               
            }

            else if (Input.GetKeyDown(KeyCode.S))
            {
                btndown.SetActive(false);
                if (count == 3)
                {
                    count++;
                    check = true;
                }
                else check = false;
            }
        
        if (!check)
            Restart();
        
        if(count==4 && check)
           Pass();

    }
}
