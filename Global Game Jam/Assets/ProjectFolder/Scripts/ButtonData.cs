using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Button", menuName = "ButtonData")]
public class ButtonData : ScriptableObject {
	
	public bool land;

	public int m_nMinimumPopulation;
	public int m_nMaximumPopulation;

	public string startDialogue;
	public string endDialogue;

}
