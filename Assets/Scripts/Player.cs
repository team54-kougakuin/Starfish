using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PlayerMove>().enabled = false;
        GetComponent<PlayerShoot>().enabled = false;
    }
    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<PlayerMove>().enabled = !GetComponent<PlayerMove>().enabled;
            GetComponent<PlayerShoot>().enabled = !GetComponent<PlayerShoot>().enabled;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
