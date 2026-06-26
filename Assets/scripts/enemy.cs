using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject ball;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ball != null)
        {
            Vector3 pos = transform.position;
            float target_pos = ball.transform.position.y;
            pos.y = Mathf.Lerp(transform.position.y, target_pos, Time.deltaTime * 1);
            transform.position = pos;
        }
    }
}
