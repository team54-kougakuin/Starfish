using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void OnClick() {
        //Debug.Log("clicked");

        var text = gameObject.name;

        switch (text) {
            case "TitleButton": text = "Title"; break;
            case "NextButton": text = "SampleScene"; break;
            case "SelectButton": text = "select"; break;
        }
        Debug.Log(text);
        SceneManager.LoadScene(text);
    }
}
