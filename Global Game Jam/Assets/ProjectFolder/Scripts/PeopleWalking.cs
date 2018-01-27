using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleWalking : MonoBehaviour {

	public float walkMin = 2;
	public float walkMax = 5;

	public float idleMin = 2;
	public float idleMax = 7;

	public Animator anim;
	public bool isMoving;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		RandomMoving ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void RandomMoving () {
		int boolswap = 	Random.Range (0, 3);
		if (boolswap == 1) {
			isMoving = true;
			anim.SetBool ("IsMoving", true);
			//Chance to Rotate character
			int inverseCharacter = 	Random.Range (0, 3);
			if (inverseCharacter == 1) {
				transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
			}
			//Walks for X Seconds
			StartCoroutine (WaitTime (Random.Range (walkMin - 1, walkMax + 1)));
		} else {
			isMoving = false;
			anim.SetBool ("IsMoving", false);
			//Idles for X Seconds
			StartCoroutine (WaitTime (Random.Range (idleMin - 1, idleMax + 1)));
		}
	}

	IEnumerator WaitTime (float time){
		//Suspend execution for X seconds
		yield return new WaitForSeconds(time);
		RandomMoving ();
	}
}
