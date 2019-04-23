using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    public GameObject ld;
    public GameObject ru;

    [HideInInspector]
    public Camera camera;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
<<<<<<< HEAD

        ld = GameObject.FindGameObjectWithTag("BottomLeft");
        ru = GameObject.FindGameObjectWithTag("TopRight");
=======
        
>>>>>>> 7ac21ffb5135e353e28d43891b6ae299e1bfe9b4
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (ld == null || ru == null)
=======
        if (ld == null || ru ==null)
>>>>>>> 7ac21ffb5135e353e28d43891b6ae299e1bfe9b4
        {
            ld = GameObject.FindGameObjectWithTag("BottomLeft");
            ru = GameObject.FindGameObjectWithTag("TopRight");
        }
<<<<<<< HEAD
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
=======
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -20);
>>>>>>> 7ac21ffb5135e353e28d43891b6ae299e1bfe9b4
        CameraClamp();

        transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }

    void CameraClamp()
    {
        if (ld != null && ru != null)
        {
            Vector3 pos = transform.position;
            
            //画面の四隅の座標を取得
            Vector3 downLeft = camera.ViewportToWorldPoint(Vector3.zero);
            Vector2 downLeft2D = new Vector2(downLeft.x, downLeft.y);
            Vector3 topRight = camera.ViewportToWorldPoint(Vector3.one);
            Vector2 topRight2D = new Vector2(topRight.x, topRight.y);
            Vector2 topLeft = new Vector2(downLeft2D.x, topRight2D.y);
            Vector2 downRight = new Vector2(topRight2D.x, downLeft2D.y);


            float wid = Vector2.Distance(downLeft2D, downRight);
            float hei = Vector2.Distance(topLeft, downLeft2D);
            
            pos.x = Mathf.Clamp(pos.x, ld.transform.position.x + wid / 2, ru.transform.position.x - wid / 2);
            pos.y = Mathf.Clamp(pos.y, ld.transform.position.y + hei / 2, ru.transform.position.y - hei / 2);

            //Debug.Log(lu.transform.position.x);

            transform.position = pos;
        }
    }
}
