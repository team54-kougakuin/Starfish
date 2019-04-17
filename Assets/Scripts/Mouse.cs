using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Texture2D texture;
    public Vector3 mousePos;

    public Vector3 MousePos
    {
        get { return this.mousePos; }
        private set { this.mousePos = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        //カーソルの画像をTexture、ホットスポットを画像サイズの半分、表示をForceSoftware(ソフトウェアカーソルを使用)に設定
        Cursor.SetCursor(texture, new Vector2(texture.width / 2, texture.height / 2), CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            Debug.Log(mousePos);
        }
    }
}
