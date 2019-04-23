using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//一時的なPrefab用のPlayer
public class PrefabPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PlayerCtrl>().enabled = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<PlayerCtrl>().enabled = !GetComponent<PlayerCtrl>().enabled;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (GetComponent<PlayerCtrl>().enabled)
            {
                GetComponent<Player>().enabled = true;
                GetComponent<PrefabPlayer>().enabled = false;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
