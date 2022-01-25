using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedShape : Shape
{
    public void Start() {
        Name = "The Red Cube";
        TextToDisplay = "The red cube has been chosen";
    }

    public override void Displaytext() {
        MainUIHandler.Instance.DisplayedText.text = TextToDisplay;
    }
}
