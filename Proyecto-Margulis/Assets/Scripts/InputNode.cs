using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//punto que "acepta" moleculas arrastrables
public class InputNode : MonoBehaviour
{

    //que molecula acepta
    public Molecule InputMolecule;
    public Proccess process;

    private bool locked;
    private GameObject inmolecule;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseUp()
    {
        if (Drag.Actual != null)
        {
            DragMolecule d = Drag.Actual as DragMolecule;
            if (InputMolecule == d.molecule)
            {
                Lock(d.gameObject);
            } else
            {

            }
        }
    }

    public void Lock(GameObject other)
    {
        locked = true;
        inmolecule = other;
        other.transform.SetParent(this.transform);
    }


    public bool IsLocked() { return locked; }
}
