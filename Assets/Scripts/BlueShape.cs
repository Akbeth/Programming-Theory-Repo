using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueShape : Shape
{
    public void Start() {
        Name = "The Blue Cube";
        TextToDisplay = "The blue cube has been chosen";
    }

    public override void Displaytext() {
        MainUIHandler.Instance.DisplayedText.text = TextToDisplay;
    }
}
