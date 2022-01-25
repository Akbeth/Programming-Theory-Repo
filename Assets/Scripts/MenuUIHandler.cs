using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{

    public Text PlayerName;
    public void StartNew() {
        SceneManager.LoadScene(1);
    }

    public void NameChanged() {
        MainManager.Instance.PlayerName = PlayerName.text; 
    }
}
