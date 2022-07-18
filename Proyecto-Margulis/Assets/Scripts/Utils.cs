using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Utils : MonoBehaviour
{

    public GameObject PopupPrefab;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public static void ChangeScene(string s)
    {
        SceneManager.LoadScene(s);
    }

    public static string Float2Time(float f)
    {
        return Mathf.FloorToInt(f / 60).ToString() + ":" + (f % 60).ToString();
    }

    //spawnea siempre en el mismo lugar
    public void SpawnPopup(string t, string c)
    {
        UI_Popup p = Instantiate(PopupPrefab, transform).GetComponent<UI_Popup>();
        p.PutContent(t, c);

    }
}
