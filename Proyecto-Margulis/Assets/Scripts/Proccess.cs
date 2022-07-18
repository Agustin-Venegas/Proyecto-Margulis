using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Proceso que requiere inputs y genera outputs. Hace las animaciones cuando se cumplen sus requisitos
//Representa enzimas y otras estructuras grandes

public class Proccess : MonoBehaviour
{
    public InputNode[] inputNodes; //Inputs requeridas
    public UnityEvent OnActivate;
    public bool ActivateOnInput = true;

    public float time;
    public UnityEvent OnFinish;

    private bool activated = false;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ActivateOnInput && !activated)
        {
            if (Activate())
            {
                StartCoroutine(ExecuteAfterTime(time));
            }
        }
    }

    //regresa si se activo o no
    public bool Activate() 
    {
        foreach (InputNode n in inputNodes) 
        {
            if (!n.IsLocked())
            {
                return false;
            }
        }

        OnActivate.Invoke();
        activated = true;

        return true;
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        Finish();
    }

    void Finish()
    {
        OnFinish.Invoke();

        activated = false;

        foreach (InputNode n in inputNodes)
        {
            n.Release();
        }
    }

}
