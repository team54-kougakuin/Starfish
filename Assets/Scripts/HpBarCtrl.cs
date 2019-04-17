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
    

    // Start is called before the first frame update
    void Start()
    {
        playerShoot = player.GetComponent<PlayerShoot>();
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp > _slider.minValue)
        {
            hp -= 0.1f;
        }
        else
        {
            hp = 0;
        }

        if (Input.GetMouseButtonDown(0) && playerShoot.IsShootFlag())
        {
            hp -= 10;
        }

        _slider.value = hp;

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            hp = _slider.maxValue;
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
