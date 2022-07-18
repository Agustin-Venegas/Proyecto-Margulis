using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//molecula arrastrable, debe tener una referencia a una molecula
public class DragMolecule : Drag, IHelpClickable
{
    public Molecule molecule;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDown()
    {
        isDragging = true;
        Actual = this;

        Debug.Log("Click registrado");
    }

    void OnMouseUp()
    {
        isDragging = false;
        Actual = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }

    public void DisableInteraction()
    {
        isDragging = false;
        Actual = null;

        enabled = false;
    }

    public void Clone()
    {
        GameObject c = Instantiate(this.gameObject);
        c.SetActive(true);
        c.transform.SetParent(this.transform.parent,true);
    }

    public Molecule GetMoleculeInfo()
    {
        return molecule;
    }
}
