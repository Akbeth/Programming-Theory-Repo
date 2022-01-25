using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    public static MainUIHandler Instance;

    public Text DisplayedText;

    public void Awake() {
        Instance = this;
    }

}
