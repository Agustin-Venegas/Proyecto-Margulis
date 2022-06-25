using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Proceso que requiere inputs y genera outputs. Hace las animaciones cuando se cumplen sus requisitos
public class Proccess : MonoBehaviour
{
    public InputNode[] inputNodes; //Inputs requeridas
    public UnityEvent OnActivate;
    public bool ActivateOnInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

        return true;
    }
}
