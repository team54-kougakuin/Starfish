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
        GetComponent<PlayerCtrl>().enabled = true;
        GetComponent<PlayerShoot>().enabled = true;

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
    }

    private void FixedUpdate()
    {
    }
}
