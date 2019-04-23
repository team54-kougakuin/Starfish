using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    [SerializeField]
    private float jumpPower = 300;//ジャンプ力

    [SerializeField]
    public LayerMask groundLayer;//Linecastで判定するLayer

    [SerializeField]
    private LayerMask enemyLayer;//Linecastで判定するLayer

    private bool isGround;//着地判定

    private Rigidbody2D rb;

    private bool isDeadFlag = false;

    private Animator anim;
    
    private HpBarCtrl hPbar;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        hPbar = GameObject.FindGameObjectWithTag("HpBarCtrl").GetComponent<HpBarCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDeadFlag == true)
        {
            SceneManager.LoadScene("Title");
        }

        if (hPbar.IsDead())
        {
            isDeadFlag = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var input = Input.GetAxisRaw("Horizontal");
        var component = GetComponent<Rigidbody2D>();
        var velocity = component.velocity;
        velocity.x = input * speed;
        component.velocity = velocity;

        //anim.SetFloat("run", input);  //歩くアニメーション



        //LinecastでPlayerの足元に地面があるか判定
        isGround = Physics2D.Linecast(
                transform.position + transform.up * (-0.55f * transform.localScale.y),
                transform.position - transform.up * 1f,
                groundLayer);

        if (isGround == false)//enemyの上にいるときのジャンプ
        {
            isGround = Physics2D.Linecast(
            transform.position + transform.up * (-0.55f * transform.localScale.y),
            transform.position - transform.up * 1f,
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

        Debug.Log(isGround);
    }

    public void IsDead()
    {
        isDeadFlag = true;
    }


}
