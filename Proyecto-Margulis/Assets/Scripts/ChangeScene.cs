using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public string scene;
    public void Change()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }

    public void Change(string s)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(s);
    }
}
