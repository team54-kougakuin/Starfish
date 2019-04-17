using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    private PlayerShoot playerShoot;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PlayerCtrl>().enabled = true;
        GetComponent<PlayerShoot>().enabled = true;

        playerShoot = GetComponent<PlayerShoot>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !playerShoot.ShootFlag())
        {
            GetComponent<PlayerCtrl>().enabled = !GetComponent<PlayerCtrl>().enabled;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (playerShoot.ShootFlag())
        {
            GetComponent<PlayerCtrl>().enabled = true;
        }
    }
}
