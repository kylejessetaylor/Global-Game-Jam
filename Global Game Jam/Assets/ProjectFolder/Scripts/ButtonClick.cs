using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public ButtonData buttonStats;

    public float m_fTimer;

    public bool m_bFirstBang;
    public bool m_bClick;

    public bool land;

    public int m_nPopulation;
    public bool playerLocation;

	public Text textDialogue;
	public string startDialogue;
	public string endDialogue;

    public GameObject m_goNuke;

    public GameObject m_goExplosion;

    public int m_nLastClickKillCount;
    // Use this for initialization
    void Awake()
    {
        m_nPopulation = Random.Range(buttonStats.m_nMinimumPopulation, buttonStats.m_nMaximumPopulation);
        //m_nPopulation = Random.Range(0 - 1, 100 + 1);
        startDialogue = buttonStats.startDialogue;
		endDialogue = buttonStats.endDialogue;
	}
	
	// Update is called once per frame
	void Update ()
    {
       if(m_bClick)
        {
            m_bClick = false;
        }
	}

    public void OnMouseClick()
    {
        m_bClick = true;
        if (m_bFirstBang)
        {
            StartCoroutine(PauseBlast(m_fTimer));
        }
        else
        {
            Boom();
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "People")
        {
            if (m_bClick)
            {
                m_nLastClickKillCount += 1;
            }
        }
    }

    IEnumerator PauseBlast(float time)
    {
        yield return new WaitForSeconds(time);
        m_bFirstBang = false;
       
        Boom();
    }

    IEnumerator PauseExplosion(float time)
    {
        yield return new WaitForSeconds(time);
        GameObject goExplosion = m_goExplosion;
        goExplosion.transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
        Instantiate(goExplosion);
        // time to particle effect
    }

    public void Boom()
    {
        // this button will no longer be interactable
        GetComponent<Button>().interactable = false;
        // instantiate a nuke
        GameObject goNuke = m_goNuke;
        // Set it's position
        goNuke.transform.position = new Vector3(transform.position.x - 0.625f, transform.position.y - 1.03f, -0.1f);
        Instantiate(goNuke);
        // Start Running PauseExplosion
        PauseExplosion(3.2f);

        //static score value += m_nPopulation + (m_nKillCount * 0.2);

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
