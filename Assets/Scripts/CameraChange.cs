using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    [SerializeField]
    private GameObject mainCamera;
    [SerializeField]
    private GameObject subCamera;
<<<<<<< HEAD
=======

    private GameObject nowCam;

>>>>>>> 7ac21ffb5135e353e28d43891b6ae299e1bfe9b4
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
<<<<<<< HEAD
=======
        nowCam = mainCamera;
>>>>>>> 7ac21ffb5135e353e28d43891b6ae299e1bfe9b4
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            mainCamera.SetActive(!mainCamera.activeSelf);
            subCamera.SetActive(!subCamera.activeSelf);
<<<<<<< HEAD
=======

            if (nowCam == mainCamera)
            {
                nowCam = subCamera;
            }
            else if(nowCam == subCamera)
            {
                nowCam = mainCamera;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (nowCam == subCamera)
            {
                subCamera.tag = "MainCamera";
                this.enabled = false;
            }
>>>>>>> 7ac21ffb5135e353e28d43891b6ae299e1bfe9b4
        }
    }
}
