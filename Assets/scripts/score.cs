using System;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class score : MonoBehaviour
{
    [SerializeReference] GameObject ball;
   //public GameObject newBAll;
    public GameObject Enemy;
    private GameObject newball;
    public void Start()
    {
        newball = Instantiate(ball);
        newball.transform.position = new Vector3(5, 5, 0);
        Enemy.GetComponent<enemy>().ball = newball;
    }

   
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {

        Destroy(newball);

        newball = Instantiate(ball);
        newball.transform.position = new Vector3(5, 5, 0);
        Enemy.GetComponent<enemy>().ball = newball;

       


    }


}
