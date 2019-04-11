using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    [SerializeField]
    private float jumpPower = 700;//ジャンプ力

    [SerializeField]
    public LayerMask groundLayer;//Linecastで判定するLayer
<<<<<<< HEAD
    bool isGround;//着地判定
    public Mouse mousescript;
    Vector3 mousePos;
=======
>>>>>>> eed4470d762c197947f5ffc1b49d0ef7517327e0

    [SerializeField]
    private LayerMask enemyLayer;//Linecastで判定するLayer
    
    private bool isGround;//着地判定
    
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        mousePos = mousescript.MousePos;
        Debug.Log(mousePos);
    }
    
    void Update()
    { 

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
            transform.position + transform.up * (-0.55f * transform.localScale.y),
            transform.position - transform.up * 0.05f,
            groundLayer);

        if (isGround==false)
        {
            isGround = Physics2D.Linecast(
            transform.position + transform.up * (-0.55f * transform.localScale.y),
            transform.position - transform.up * 0.05f,
            enemyLayer);
        }

        //スペースキーを押し、さらに接地しているとき
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            //着地判定をfalse
            isGround = false;
            //AddForceにて上方向へ力を加える
            rb.AddForce(Vector2.up * jumpPower);
        }

        //左クリックを押したとき
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Attack()
    {
        var movedirection = (mousePos - transform.position).normalized;

    }
}
