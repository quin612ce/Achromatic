using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange1 : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D oth)
    {
        if (oth.transform.tag == "Player")
        {
            SceneManager.LoadScene("PlayMap2");
        }
    }
}
