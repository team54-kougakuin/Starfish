using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    [SerializeField]
    private GameObject mainCamera;
    [SerializeField]
    private GameObject subCamera;

    private GameObject nowCam;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        nowCam = mainCamera;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            mainCamera.SetActive(!mainCamera.activeSelf);
            subCamera.SetActive(!subCamera.activeSelf);

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
        }
    }
}
