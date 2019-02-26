using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    public float speed = 5.0f;

    public float jumpPower = 700;//ジャンプ力
    public LayerMask groundLayer;//Linecastで判定するLayer
    bool isGround;//着地判定

    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var input = Input.GetAxisRaw("Horizontal");
        var component = GetComponent<Rigidbody2D>();
        var velocity = component.velocity;
        velocity.x = input * speed;
        component.velocity = velocity;

        //LinecastでPlayerの足元に地面があるか判定
        isGround = Physics2D.Linecast(
            transform.position + transform.up * (-0.55f*transform.localScale.y),
            transform.position - transform.up * 0.05f,
            groundLayer);
        //スペースキーを押し、さらに接地しているとき
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            //着地判定をfalse
            isGround = false;
            //AddForceにて上方向へ力を加える
            rb.AddForce(Vector2.up * jumpPower);
        }
    }
}
