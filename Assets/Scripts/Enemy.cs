using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float speed = 1;
    private float vx = 1;
    private float rightLeft;
    private GameObject ground;

    // Start is called before the first frame update
    void Start() {
        ground = GameObject.Find("Ground");
        //地面の中央から端までの長さを求める
        rightLeft = ground.transform.localPosition.x + ground.transform.localScale.x / 2;
    }

    // Update is called once per frame
    void Update() {
        //地面端まで行ったら移動量反転
        if (gameObject.transform.localPosition.x + gameObject.transform.localScale.x / 2 > rightLeft
            || gameObject.transform.localPosition.x - gameObject.transform.localScale.x / 2 < -rightLeft) {
            vx *= -1;
        }

        // 移動する向きを求める
        Vector2 direction = new Vector2(vx, 0).normalized;

        // 移動する向きとスピードを代入する
        GetComponent<Rigidbody>().velocity = direction * speed;
    }

    void OnTriggerEnter(Collider other) {
        //ぶつかったのがプレイヤーだったらプレイヤーを削除
        if (other.tag == "Player") {
            Destroy(other.gameObject);
        }

        //障害物にぶつかったら移動量反転
        vx *= -1;
    }
}
