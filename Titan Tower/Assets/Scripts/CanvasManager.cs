using UnityEngine;
using System.Collections;

public class CanvasManager : MonoBehaviour
{

    GameObject MainScreen;
    GameObject ConfigurationScreen;
    bool canvasChange;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CanvasChange()
    {
        MainScreen = GameObject.Find("MainScreen");
        ConfigurationScreen = GameObject.Find("ConfigurationScreen");
        CanvasGroup main = MainScreen.GetComponent<CanvasGroup>();
        CanvasGroup conf = ConfigurationScreen.GetComponent<CanvasGroup>();

        main.alpha = 0;
        conf.alpha = 1;

    }
}
