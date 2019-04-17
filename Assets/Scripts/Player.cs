using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
<<<<<<< HEAD
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
=======
    private PlayerShoot playerShoot;
>>>>>>> d57412bf5dba34fa06d2e43f7cff1b982e04d1fe

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        GetComponent<PlayerCtrl>().enabled = true;
        GetComponent<PlayerShoot>().enabled = true;
=======
        rb = GetComponent<Rigidbody2D>();
        
        mousePos = mousescript.MousePos;
        Debug.Log(mousePos);
    }
    
    void Update()
    { 
>>>>>>> 8423f7652a04372da34e02cbbc94cd543b7699f5

        playerShoot = GetComponent<PlayerShoot>();
    }
<<<<<<< HEAD



    // Update is called once per frame
=======
    
>>>>>>> d57412bf5dba34fa06d2e43f7cff1b982e04d1fe
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !playerShoot.ShootFlag())
        {
            GetComponent<PlayerCtrl>().enabled = !GetComponent<PlayerCtrl>().enabled;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

<<<<<<< HEAD
        //LinecastでPlayerの足元に地面があるか判定
        isGround = Physics2D.Linecast(
            transform.position + transform.up * (-0.55f * transform.localScale.y),
            transform.position - transform.up * 1.0f,
            groundLayer);

        if (isGround == false)
        {
            isGround = Physics2D.Linecast(
                transform.position + transform.up * (-0.55f * transform.localScale.y),
                transform.position - transform.up * 0.5f,
                enemyLayer);
        }

        //スペースキーを押し、さらに接地しているとき
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
=======
        if (playerShoot.ShootFlag())
>>>>>>> d57412bf5dba34fa06d2e43f7cff1b982e04d1fe
        {
            GetComponent<PlayerCtrl>().enabled = true;
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

    private void FixedUpdate()
    {
    }
}
