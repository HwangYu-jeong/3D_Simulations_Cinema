using UnityEngine;

public class Distance_fire : MonoBehaviour
{
    private GameObject Player;
    private float Dist;

    // Update is called once per frame
    void Start()
    {
        Player = GameObject.Find("Sphere");
    }
    void Update()
    {
        CheckDistance();
    }

    private void CheckDistance()
    {
        Dist = Vector3.Distance(Player.transform.position, gameObject.transform.position);
        if (Dist < 2.0f)
        {
            Destroy(gameObject, 2);
        }
    }
}
