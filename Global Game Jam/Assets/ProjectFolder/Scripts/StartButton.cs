using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

    public GameObject GridButtons;

    public void StartGame()
    {
        GridButtons.SetActive(true);
        //Menu.SetActive(false);
    }

}
