using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Molecula", order = 1)]
public class Molecule : ScriptableObject, IEquatable<Molecule>
{
    public string displayName;
    public string reactantName;

    public Texture2D representation;
    public string info;

    bool IEquatable<Molecule>.Equals(Molecule other)
    {
        return this.reactantName == other.reactantName;
    }
}
