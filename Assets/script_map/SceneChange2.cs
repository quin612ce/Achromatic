﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange2 : MonoBehaviour {

void OnCollisionEnter2D(Collision2D oth)
    {
        if (oth.transform.tag == "Player")
        {
            SceneManager.LoadScene("PlayMap2_last");
        }
    }
}