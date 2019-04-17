using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private bool isHit = false;

<<<<<<< HEAD
=======
    [SerializeField]
    private GameObject player;

>>>>>>> d57412bf5dba34fa06d2e43f7cff1b982e04d1fe
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
=======
        Vector3 pos = transform.position;

>>>>>>> d57412bf5dba34fa06d2e43f7cff1b982e04d1fe
        if (isHit)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
<<<<<<< HEAD
=======

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
>>>>>>> d57412bf5dba34fa06d2e43f7cff1b982e04d1fe
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isHit = true;
    }
}
