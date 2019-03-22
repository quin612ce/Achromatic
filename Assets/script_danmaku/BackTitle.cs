using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackTitle : MonoBehaviour {

	public void ButtonClicked () {
        SceneManager.LoadScene ("Title");
    }
}