using System;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class score : MonoBehaviour
{
    [SerializeField] BoxCollider2D leftwall;
    [SerializeField] BoxCollider2D rightwall;
    [SerializeField] private TMP_Text playerscore_text;
    [SerializeField] private TMP_Text enemyscore_text;
    [SerializeReference] GameObject ball;
    private int _playerscore = 0;
    private int _enemyscore = 0;
    public int playerscore
    {
        get {return _playerscore; }
        set 
        {

            _playerscore = value;
            returnscorePlayer(); 
        }
    }

    public int enemyscore
    {
        get { return _enemyscore; }
        set
        {
            
            _enemyscore += value;
            returnscoreEnemy();
        }
    }

   //public GameObject newBAll;
    public GameObject Enemy;
    private GameObject newball;
    public void Start()
    {

         newball = Instantiate(ball);
        newball.transform.position = new Vector3(6, 5, 0);
        Enemy.GetComponent<enemy>().ball = newball;
    }

   
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.position.x < 1)
        {
            
            playerscore += 1;
        }
        if (other.transform.position.x > 10 )
        {
            enemyscore += 1;
        }

        Destroy(newball);
        newball = Instantiate(ball);
        newball.transform.position = new Vector3(5, 5, 0);
        Enemy.GetComponent<enemy>().ball = newball;
    }
    public void returnscorePlayer()
        {
        Debug.Log("work");
        playerscore_text.text = playerscore.ToString();        
        }
    public void returnscoreEnemy()
    {
       
        enemyscore_text.text = enemyscore.ToString();
    }  


    }





