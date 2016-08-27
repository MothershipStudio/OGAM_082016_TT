using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Represents a scene and his caller
/// </summary>
[System.Serializable]
public struct SceneSet {
    public string sceneName;
    public Button sceneButton;
}

/// <summary>
/// Handles the binding of scenes and their callers
/// </summary>
public class ScenesManager : MonoBehaviour {
    public SceneSet[] sceneSet;

    void Start () {
        foreach(var ss in sceneSet)
            ss.sceneButton.onClick.AddListener(() => SceneManager.LoadScene(ss.sceneName));
    }
}
