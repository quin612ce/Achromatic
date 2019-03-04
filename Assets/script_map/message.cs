using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message : MonoBehaviour {

	public GameObject Message;

	void OnTriggerStay2D(Collider2D oth)
    {
        if (oth.transform.tag == "Player")
        {
			if (Input.GetKeyDown(KeyCode.Return)) {
				Message.SetActive (true);
			}
        }
		/*else {
			Message.SetActive (false);
			}*/
    }
}
