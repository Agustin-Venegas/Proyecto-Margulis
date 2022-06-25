using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Clase que abarca todos los procesos
public class Mitochondria : MonoBehaviour
{

    private int ATP;
    private int Glucose;
    private int Piruvate;
    private int CO2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //deberia actualizar todas las variables/ejecutar todos los procesos
    public void Frame()
    {

    }

    //glicolisis a una glucosa
    public void Glucolisis() 
    {
        Glucose--;
        ATP += 2;
        Piruvate += 2;
    }

    public void PiruvateOxidation()
    {
        
    }
}
