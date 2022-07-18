using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DigitalRuby.Tween;

public class UI_Popup : MonoBehaviour
{
    public Text title;
    public Text content;
    public UnityEvent OnDismiss;

    //public float width;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PutContent(string t, string c)
    {
        title.text = t;
        content.text = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dismiss()
    {
        System.Action<ITween<Vector3>> updatePos = (t) =>
        {
            transform.position = t.CurrentValue;
        };

        System.Action<ITween<Vector3>> complete = (t) => 
        {
            OnDismiss.Invoke();
            Destroy(gameObject);
        };

        enabled = false;

        TweenFactory.Tween(null, transform.position, new Vector3(-300,300,0), 1, TweenScaleFunctions.CubicEaseIn, updatePos,complete);
    }
}
