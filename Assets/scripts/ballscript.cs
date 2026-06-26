using UnityEngine;
using System;
using Unity.VisualScripting;
public class BAAL : MonoBehaviour

{
    public Component script;
    [SerializeField] int ball_speed = 3;
    private Rigidbody2D rb;
    BoxCollider2D col;
    public GameObject obj;
    static System.Random rng;
    float randvectorX;
    float randvectorY;
    public Vector2 targetPos;
    public void Start()
    {
        randvectorX = UnityEngine.Random.Range(0.2f, 12f);
        randvectorY = UnityEngine.Random.Range(0, 10);
        col = GetComponent<BoxCollider2D>();
          rb = GetComponent<Rigidbody2D>();
      targetPos = new Vector2(randvectorX, randvectorY * 10);

    }
    public void FixedUpdate()
    {
        float step = ball_speed * Time.deltaTime;
       
        rb.MovePosition(Vector3.MoveTowards(transform.position,targetPos,step));
    }
    public void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("WallDown"))
        {
            if (transform.position.x < 6f)
            {
                targetPos = new Vector2(0, UnityEngine.Random.Range(1f, 10f) / 2);
            }
            if (transform.position.x > 6f)
            {
                targetPos = new Vector2(12, UnityEngine.Random.Range(1f, 10f) / 2 + 5);
            }
        }
        else if (collider.gameObject.CompareTag("Wall"))
        {

            if (transform.position.x < 6f)
            {
                targetPos = new Vector2(0, UnityEngine.Random.Range(0.2f, 10f) / 2 );
            }
            if (transform.position.x > 6f)
            {
                targetPos = new Vector2(12, UnityEngine.Random.Range(0.2f, 10f) / 2 + 5);
            }
        }
        else if (collider.gameObject.CompareTag("Player"))
        {
            if (transform.position.y < 5)
            {
                targetPos = new Vector2(UnityEngine.Random.Range(7f, 12f), 10f);
            }
            if (transform.position.y > 5)
            {
                targetPos = new Vector2(UnityEngine.Random.Range(7f, 12f), 0f);
            }
        }
        else if (collider.gameObject.CompareTag("wallbounce"))
        {
            if (transform.position.y < 5)
            {
                targetPos = new Vector2(UnityEngine.Random.Range(1f, 6f), 10f);
            }
            if (transform.position.y > 5)
            {
                targetPos = new Vector2(UnityEngine.Random.Range(1f, 6f), 0f);
            }
        }
    }
}
