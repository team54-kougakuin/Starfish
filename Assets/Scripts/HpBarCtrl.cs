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
        _slider = GameObject.Find("Slider").GetComponent<Slider>();

        pause = pauseCamera.GetComponent<PauseScript>();

        playerc = pldead.GetComponent<PlayerCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
=======
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            playerShoot = player.GetComponent<PlayerShoot>();
        }
        Debug.Log(playerShoot.IsShootFlag());

        if (hp > _slider.minValue)
        {
            hp -= 0.1f;
        }
        else
        {
            hp = 0;
        }
>>>>>>> 7ac21ffb5135e353e28d43891b6ae299e1bfe9b4

        if (!pause.PaCheck())
        {

<<<<<<< HEAD
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
=======
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            hp = _slider.maxValue;
>>>>>>> 7ac21ffb5135e353e28d43891b6ae299e1bfe9b4
        }

        _slider.value = hp;
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
