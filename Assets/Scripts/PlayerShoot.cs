using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;

    [SerializeField]
    private GameObject bullet;

    private bool isShoot = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isShoot)
        {
            isShoot = false;

            //弾の生成
            GameObject clone = Instantiate(bullet, transform.position, Quaternion.identity);

            //クリックした座標の取得(スクリーン座標からワールド座標へ）
            Vector3 mouseWorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //向き
            Vector3 shotForward = Vector3.Scale((mouseWorPos - transform.position), new Vector3(1, 1, 0)).normalized;

            //速度
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;
        }

        if (Input.GetMouseButtonDown(1))
        {
            isShoot = true;
        }
    }
}
