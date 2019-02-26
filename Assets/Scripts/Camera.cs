using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;

    public float screenLeft;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, 0, -20);

        if (transform.position.x<-0.5f)
        {
            transform.position = new Vector3(-0.5f, 0, -20);
        }

        if (transform.position.x>=1.5f)
        {
            transform.position = new Vector3(1.5f, 0, -20);
        }
    }
}
