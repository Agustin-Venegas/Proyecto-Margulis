using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//punto que "acepta" moleculas arrastrables
public class InputNode : MonoBehaviour, IHelpClickable
{

    //que molecula acepta
    public Molecule InputMolecule;
    public Proccess process;
    public Molecule Name;

    bool locked;
    private GameObject inmolecule;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        if (Drag.Actual != null && !locked)
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DragMolecule m = collision.attachedRigidbody.gameObject.GetComponent<DragMolecule>();

        if (m.molecule == InputMolecule)
        {
            Lock(m.gameObject);
        }
    }

    public void Lock(GameObject other)
    {
        locked = true;
        inmolecule = other;
        other.transform.SetParent(this.transform,true);

        other.GetComponent<DragMolecule>().DisableInteraction();
    }

    public void Release()
    {
        locked = false;
        Destroy(inmolecule);
    }


    public bool IsLocked() { return locked; }

    public void AttractReactants()
    {
        foreach (DragMolecule m in Object.FindObjectsOfType<DragMolecule>())
        {
            if (m == InputMolecule)
            {
                m.transform.position += (transform.position - m.transform.position).normalized * 10;
            }
        }
    }

    public Molecule GetMoleculeInfo()
    {
        return Name;
    }
}
