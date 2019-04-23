using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;

    [SerializeField]
    private GameObject bullet;

    private bool isShoot = true;
    private bool shoot = true;

    private HpBarCtrl hpCtrl;

    // Start is called before the first frame update
    void Start()
    {
        hpCtrl = GetComponent<HpBarCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isShoot)
        {
            isShoot = false;

            //弾の生成
            GameObject clone = Instantiate(bullet, transform.position, Quaternion.identity/*回転*/);

            //クリックした座標の取得(スクリーン座標からワールド座標へ）
            Vector3 mouseWorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //向き
            Vector3 shotForward = Vector3.Scale((mouseWorPos - transform.position), new Vector3(1, 1, 0)).normalized;

            //速度
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;
        }

        if (Input.GetMouseButtonDown(2) && shoot)
        {
            isShoot = true;
        }

        if (Input.GetMouseButtonDown(1) && !isShoot)
        {
            shoot = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && !shoot)
        {
            shoot = true;
            isShoot = true;
        }
    }

    public bool ShootFlag()
    {
        return shoot;
    }

    public bool IsShootFlag()
    {
        return isShoot;
    }
}
