using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message : MonoBehaviour {
	
	public GameObject Message;

	void OnCollisionEnter2D(Collision2D oth)
    {
        if (oth.transform.tag == "Player")
        {
            Message.SetActive (true);;
        }
    }
}
