using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//clase para agarrar objetos. Guarda el actual como static
public class Drag : MonoBehaviour
{
    public bool isDragging = false;

    public static Drag Actual;

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
}
