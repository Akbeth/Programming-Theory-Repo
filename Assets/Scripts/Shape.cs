using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{

    public string Name { get; protected set; }
    public string TextToDisplay { get; protected set; }
    public abstract void Displaytext();
}
