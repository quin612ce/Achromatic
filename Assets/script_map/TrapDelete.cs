using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDelete : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D oth)
    {
        if (oth.transform.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
