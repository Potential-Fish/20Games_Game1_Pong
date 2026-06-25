using UnityEngine;
using UnityEngine.UIElements;

public class player_pong : MonoBehaviour
{
    float player_move_speed = 3.0f;
    public GameObject player;
    void Start()
    {
       
    }

    
    public void Update()
    {
       
        
            transform.position += new Vector3(0, player_move_speed, 0) * Time.deltaTime * Input.GetAxis("Vertical");
        
    }
}
