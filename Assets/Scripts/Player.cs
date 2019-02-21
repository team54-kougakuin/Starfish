using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var input = Input.GetAxisRaw("Horizontal");
        var component = GetComponent<Rigidbody2D>();
        var velocity = component.velocity;
        velocity.x = input * 5f;
        component.velocity = velocity;

    }
}
