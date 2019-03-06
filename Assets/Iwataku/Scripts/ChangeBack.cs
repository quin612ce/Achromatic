using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBack : MonoBehaviour {

	private string sceneName;

	void Start () {
		sceneName = PlayerPrefs.GetString("reScene","");
		if(sceneName == "PlayMap1"){
			GameObject.Find("BackGraundManager").transform.Find("背景＿喜").gameObject.SetActive(true);
		}
		if(sceneName == "PlayMap2"){
			GameObject.Find("BackGraundManager").transform.Find("背景＿怒").gameObject.SetActive(true);
		}
		if(sceneName == "PlayMap3"){
			GameObject.Find("BackGraundManager").transform.Find("背景＿哀").gameObject.SetActive(true);
		}
		if(sceneName == "PlayMap4"){
			GameObject.Find("BackGraundManager").transform.Find("背景＿楽").gameObject.SetActive(true);
		}
	}
}
