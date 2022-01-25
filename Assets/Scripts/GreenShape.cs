using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class GreenShape : Shape
{
    public void Start() {
        Name = "The Green Cube";
        TextToDisplay = "The green cube has been chosen";
    }

    // POLYMORPHISM
    public override void Displaytext() {
        MainUIHandler.Instance.DisplayedText.text = TextToDisplay;
    }
}
