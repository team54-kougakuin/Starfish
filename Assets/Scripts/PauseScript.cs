using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour
{

    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject pauseUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject pauseUIInstance;

    private bool pausecheck = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            if (pauseUIInstance == null)
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Time.timeScale = 0f;
                pausecheck = true;
            }
            else
            {
                Destroy(pauseUIInstance);
                Time.timeScale = 1f;
                pausecheck = false;
            }
        }
    }

    public bool PaCheck()
    {
        return pausecheck;
    }
}
