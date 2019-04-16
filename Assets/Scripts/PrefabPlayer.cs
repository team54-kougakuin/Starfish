using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//一時的なPrefab用のPlayer
public class PrefabPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PlayerMove>().enabled = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<PlayerMove>().enabled = !GetComponent<PlayerMove>().enabled;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
