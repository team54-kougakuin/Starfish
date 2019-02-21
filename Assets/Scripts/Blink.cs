using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Blink : MonoBehaviour
{
    public float interval = 1.0f;
    Image renderComponent;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        renderComponent = GetComponent<Image>();
        StartCoroutine("_Blink");
    }
    void Update()
    {
        Debug.Log("Update");

    }
    IEnumerator _Blink()
    {
        Debug.Log("Call blink");
        while (true)
        {
            Debug.Log("BLINK image is enable:" + renderComponent.enabled);
            renderComponent.enabled = !renderComponent.enabled;
            yield return new WaitForSeconds(interval);
        }
        
    }

}

