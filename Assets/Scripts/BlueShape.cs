using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class BlueShape : Shape
{
    public void Start() {
        Name = "The Blue Cube";
        TextToDisplay = "The blue cube has been chosen";
    }
    // POLYMORPHISM
    public override void Displaytext() {
        MainUIHandler.Instance.DisplayedText.text = TextToDisplay;
    }
}
