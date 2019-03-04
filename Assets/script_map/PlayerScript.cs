using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.Translate (0.1f, 0, 0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
			this.gameObject.transform.Translate (-0.1f, 0, 0);
        }
		else if(Input.GetKey(KeyCode.UpArrow))
        {
			this.gameObject.transform.Translate (0, 0.1f, 0);
        }
		else if(Input.GetKey(KeyCode.DownArrow))
        {
			this.gameObject.transform.Translate (0, -0.1f, 0);
        }
    }
}