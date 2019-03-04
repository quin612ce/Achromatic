using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message : MonoBehaviour {

	public GameObject Message;
	public int Count;
	public int shift;

	void OnTriggerStay2D(Collider2D oth)
    {
        if (oth.transform.tag == "Player")
        {
			if (Input.GetKeyDown(KeyCode.Return)) {
				Message.SetActive (true);
			}
        }
    }
}
