using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{

    // ENCAPSULATION
    public string Name { get; protected set; }
    // ENCAPSULATION
    public string TextToDisplay { get; protected set; }
    public abstract void Displaytext();
}
