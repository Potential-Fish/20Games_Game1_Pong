using UnityEngine;
using System;
public class ball : MonoBehaviour
{
    [SerializeField] int ball_speed = 3;
    private Rigidbody2D rb;
    BoxCollider2D col;
    public GameObject obj;
    void Start()
    {
        col = GetComponent<BoxCollider2D>();
          rb = GetComponent<Rigidbody2D>();
       rb.AddForce(new Vector3(ball_speed, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
       
        rb.linearVelocity = new Vector3(ball_speed, 1, 0);
      
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        ball_speed = ball_speed * -1;
        Debug.Log("imgone lol");
    }

}
