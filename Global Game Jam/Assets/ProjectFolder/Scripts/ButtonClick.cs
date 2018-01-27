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

	public Text textDialogue;
	public string startDialogue;
	public string endDialogue;

    // Use this for initialization
    void Awake()
    {
        m_nPopulation = Random.Range(buttonStats.m_nMinimumPopulation-1, buttonStats.m_nMaximumPopulation+1);
		startDialogue = buttonStats.startDialogue;
		endDialogue = buttonStats.endDialogue;
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
        if (playerLocation == true)
        {
            // player has been found,
            // end game sstuff.
			//textDialogue = 
        }
        else
        {
            // player has not been found
//			textDialogue = startDialogue + m_nPopulation + endDialogue;
            // sonar(?) pointing in general direction of player || hot/cold display.
        }
    }
}
