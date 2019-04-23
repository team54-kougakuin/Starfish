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

        Change();

        if (playerShoot.ShootFlag())
        {
            GetComponent<PlayerCtrl>().enabled = true;
        }
    }

    void Change()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (GetComponent<PlayerCtrl>().enabled == false)
            {
                Destroy(gameObject);
            }
        }
    }
}
