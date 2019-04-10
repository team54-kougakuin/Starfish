using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    public GameObject stage;
    public GameObject lu;
    public GameObject rd;
    
    [HideInInspector]
    public Camera camera;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = stage.GetComponent<SpriteRenderer>(); 
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -20);
        CameraClamp();
    }

    void CameraClamp()
    {
        if (stage!=null)
        {
            Vector3 pos = transform.position;

            ////ターゲットの左上と右下の座標
            //Vector2 max = spriteRenderer.sprite.bounds.max;
            //Vector2 min = spriteRenderer.sprite.bounds.min;

            //Debug.Log(Screen.width);
            //Debug.Log(max.x);
            Vector3 downLeft = camera.ViewportToWorldPoint(Vector3.zero);
            Vector2 downLeft2D = new Vector2(downLeft.x, downLeft.y);
            Vector3 topRight = camera.ViewportToWorldPoint(Vector3.one);
            Vector2 topRight2D = new Vector2(topRight.x, topRight.y);
            Vector2 topLeft = new Vector2(downLeft2D.x, topRight2D.y);
            Vector2 downRight = new Vector2(topRight2D.x, downLeft2D.y);

            float a = Vector2.Distance(downLeft2D, downRight);
            float b = Vector2.Distance(topLeft, downLeft2D);

            Debug.Log(a + "," + b);

            pos.x = Mathf.Clamp(pos.x, lu.transform.position.x + a / 2, rd.transform.position.x - a / 2);
            pos.y = Mathf.Clamp(pos.y, lu.transform.position.y + b / 2, rd.transform.position.y - b / 2);

            //Debug.Log(lu.transform.position.x);

            transform.position = pos;
        }
    }

    void PlayerClamp()
    {
        if (player != null)
        {
            Vector3 pos = player.transform.position;

            
        }
    }
}
