using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    // Method for level loading.
    public void LoadScene(int scene)
    {
        if (scene == 0)
        {
            Application.Quit();
        }
        else
        {
            Application.LoadLevel(scene);
        }
    }

}
