using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using DigitalRuby.Tween;
using TMPro;

public class UI_BreakingText : MonoBehaviour
{
    public TextMeshProUGUI ScrollingText;
    TextMeshProUGUI cloneText;
    RectTransform rect;

    public TextAsset text;
    string[] lines;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        /*
        string fs = text.text;
        string[] fLines = Regex.Split(fs, "\n|\r|\r\n");

        //actualText = Instantiate(ScrollingText);

        System.Action<ITween<Vector3>> updatePos = (t) =>
        {
            transform.position = t.CurrentValue;
        };


        //TweenFactory.Tween(null,cloneText.transform.position,new Vector3(-500,0,0),5,TweenScaleFunctions.Linear,updatePos);

        */
        ChangeText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ChangeText()
    {
        float width = ScrollingText.preferredWidth;

        Vector3 position = ScrollingText.gameObject.transform.position;

        float pos = 0;

        while (true)
        {
            if (ScrollingText.havePropertiesChanged)
            {
                width = ScrollingText.preferredWidth;
                cloneText.text = ScrollingText.text;
            }

            rect.position = new Vector3(-pos%width, position.y, position.z);

            pos += 10 * 20 * Time.deltaTime;

            yield return true;
        }
    }


}
