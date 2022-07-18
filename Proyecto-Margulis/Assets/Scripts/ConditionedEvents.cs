using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ConditionedEvents : MonoBehaviour
{

    public List<Condition> conditions;
    public UnityEvent OnCompleted;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*foreach (Condition c in conditions)
        {
            if (!c.IsCompleted())
            {
                return;
            }
        }

        OnCompleted.Invoke();
        gameObject.SetActive(false);
        */
    }

    public bool TriggerEvent()
    {
        foreach (Condition c in conditions)
        {
            if (!c.IsCompleted())
            {
                return false;
            }
        }

        OnCompleted.Invoke();
        gameObject.SetActive(false);

        return true;
    }
}
