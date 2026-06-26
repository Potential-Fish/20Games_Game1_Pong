using UnityEngine;
using System;
using Unity.VisualScripting;
public class ball : MonoBehaviour
{
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
    public void Update()
    {
        float step = ball_speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, targetPos,step );
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.tag == "WallDown")
        {
            if (transform.position.x < 6f)
            {
                targetPos = new Vector2(0, UnityEngine.Random.Range(1f, 10f) / 2);
            }
            if (transform.position.x > 6f)
            {
                targetPos = new Vector2(12, UnityEngine.Random.Range(1f, 10f) / 2 + 6);
            }
        }
        else if (collider.tag == "Wall")
        {

            if (transform.position.x < 6f)
            {
                targetPos = new Vector2(0, UnityEngine.Random.Range(0.2f, 10f) / 2 );
            }
            if (transform.position.x > 6f)
            {
                targetPos = new Vector2(12, UnityEngine.Random.Range(0.2f, 10f) / 2 + 6);
            }
        }
        else if (collider.tag == "Player")
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
        else if (collider.tag == "wallbounce")
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
