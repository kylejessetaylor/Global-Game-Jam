using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public ButtonData buttonStats;

    public bool land;


    public int m_nPopulation;
    public bool playerLocation;

    // Use this for initialization
    void Awake()
    {
        m_nPopulation = Random.Range(buttonStats.m_nMinimumPopulation, buttonStats.m_nMaximumPopulation);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void OnMouseClick()
    {
        GetComponent<Button>().interactable = false;
        // cue animation, directed somehow to transform.position of this button.

        //static score value += GetComponent<ButtonData>().population;
        if (GetComponent<ButtonData>().playerLocation)
        {
            // player has been found,
            // end game sstuff.
        }
        else
        {
            // player has not been found
            // text cue
            // sonar(?) pointing in general direction of player || hot/cold display.
        }
    }
}
