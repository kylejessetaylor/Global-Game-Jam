using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public float m_fTimer;

    public GameObject m_goOptionalSpawn;

	// Use this for initialization
	void Awake()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Destroy(gameObject, m_fTimer);
        if(m_goOptionalSpawn)
        {
            PauseExplosion(3.1f);
        }
    }
    IEnumerator PauseExplosion(float time)
    {
        yield return new WaitForSeconds(time);
        GameObject goOptionalSpawn = m_goOptionalSpawn;
        m_goOptionalSpawn.transform.position = transform.position;
        Instantiate(goOptionalSpawn);
    }
}
