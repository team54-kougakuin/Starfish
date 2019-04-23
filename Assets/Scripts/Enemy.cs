using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1;
    private float vx = 1;
    private float right, left;
    private GameObject ground;
    [SerializeField]
    private GameObject pldead;

    private PlayerCtrl playerc;

    // Start is called before the first frame update
    void Start()
    {
        ground = GameObject.Find("Grid");
        //Position + 地面の中央から端までの長さ
        right = ground.transform.position.x + ground.transform.localScale.x / 2;
        left = ground.transform.position.x - ground.transform.localScale.x / 2;

        playerc = pldead.GetComponent<PlayerCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
        //地面端まで行ったら移動量反転
        if (gameObject.transform.position.x + gameObject.transform.localScale.x / 2 > right ||
            gameObject.transform.position.x - gameObject.transform.localScale.x / 2 < left)
        {
            vx *= -1;
        }

        // 移動する向きを求める
        Vector2 direction = new Vector2(vx, 0).normalized;

        // 移動する向きとスピードを代入する
        //GetComponent<Rigidbody>().velocity = direction * speed;
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //ぶつかったのがプレイヤーだったらプレイヤーを削除
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            playerc.IsDead();
        }

        //障害物にぶつかったら移動量反転
        vx *= -1;
    }
}

