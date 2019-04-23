using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarCtrl : MonoBehaviour
{
    Slider _slider;
    float hp = 100;

    PlayerShoot playerShoot;
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject pauseCamera;

    private PauseScript pause;

    [SerializeField]
    private GameObject pldead;

    private PlayerCtrl playerc;

    int a = 1;


    // Start is called before the first frame update
    void Start()
    {
        playerShoot = player.GetComponent<PlayerShoot>();
        _slider = GameObject.Find("Slider").GetComponent<Slider>();

        pause = pauseCamera.GetComponent<PauseScript>();

        playerc = pldead.GetComponent<PlayerCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (!pause.PaCheck())
        {

            if (hp > _slider.minValue)
            {
                hp -= 0.1f;
            }
            else if (hp < _slider.minValue)
            {
                hp = 0;
                playerc.IsDead();
            }

            if (Input.GetMouseButtonDown(0) && !playerShoot.IsShootFlag() && a == 1)
            {
                hp -= 10;
                a = 0;
            }

            _slider.value = hp;

            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                hp = _slider.maxValue;
            }
        }
    }

    public bool IsDead()
    {
        if (hp <= 0)
        {
            return true;
        }
        return false;
    }
}
