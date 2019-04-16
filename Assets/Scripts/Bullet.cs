using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private bool isHit = false;

    [SerializeField]
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (isHit)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (Input.GetMouseButtonDown(1))
        {
            //弾を削除
            Destroy(gameObject);

            //Playerを生成
            GameObject clone = Instantiate(player,pos, Quaternion.identity);
        }

        if (Input.GetMouseButtonDown(2))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isHit = true;
    }
}
