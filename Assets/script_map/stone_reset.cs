using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stone_reset : MonoBehaviour {
	float fadeSpeed = 0.02f;        //透明度が変わるスピードを管理
	float red, green, blue, alfa;   //パネルの色、不透明度を管理
 
	public bool isFadeOut = false;  //フェードアウト処理の開始、完了を管理するフラグ
	public bool isFadeIn = false;   //フェードイン処理の開始、完了を管理するフラグ
 
	Image fadeImage;                //透明度を変更するパネルのイメージ

	public GameObject stone1;
	public GameObject stone2;
	public GameObject newPrefab1;
	public GameObject newPrefab2;
	public GameObject PL;
	public float reposX,reposY;

	void Start () {
		fadeImage = GetComponent<Image> ();
		red = fadeImage.color.r;
		green = fadeImage.color.g;
		blue = fadeImage.color.b;
		alfa = fadeImage.color.a;
	}

	void Update () {
		if(isFadeIn){
			StartFadeIn ();
		}
		if (isFadeOut) {
			StartFadeOut ();
		}
		PL = GameObject.Find("PlayerAnime");
		reposX = PL.transform.position.x;
		reposY = PL.transform.position.y;

		if (reposX >= -21 && reposX <= -3 && reposY >= -8 && reposY <= -1) {
			if (Input.GetKeyDown(KeyCode.RightShift)) {
				Debug.Log("パズルリセット1");
				isFadeOut = true;
			}
		}
		if (reposX >= 24 && reposX <= 36 && reposY >= 2 && reposY <= 17) {
			if (Input.GetKeyDown(KeyCode.RightShift)) {
				Debug.Log("パズルリセット2");
				isFadeOut = true;
					PL.gameObject.transform.Translate (0, 0, 0);
			}
		}
	}

	void StartFadeIn(){
		alfa -= fadeSpeed;                //a)不透明度を徐々に下げる
		SetAlpha ();                      //b)変更した不透明度パネルに反映する
		if(alfa <= 0){                    //c)完全に透明になったら処理を抜ける
			isFadeIn = false;             
			fadeImage.enabled = false;    //d)パネルの表示をオフにする
		}
	}
 
	void StartFadeOut(){

		GameObject stone1 = GameObject.Find ("stone1");
		GameObject _stone1 = GameObject.Find ("stone1(Clone)");
		GameObject stone2 = GameObject.Find ("stone2");
		GameObject _stone2 = GameObject.Find ("stone2(Clone)");

		fadeImage.enabled = true;  // a)パネルの表示をオンにする
		alfa += fadeSpeed;         // b)不透明度を徐々にあげる
		SetAlpha ();               // c)変更した透明度をパネルに反映する
		if(alfa >= 1){             // d)完全に不透明になったら処理を抜ける
			isFadeOut = false;
			if (reposX >= -21 && reposX <= -3 && reposY >= -8 && reposY <= -1) {
				Debug.Log("ポジション変更1");
				Destroy (stone1);
				Destroy (_stone1);
				GameObject newGameObject = Instantiate(newPrefab1) as GameObject;
				PL.transform.position = new Vector3(-25, -6, -2);
			} else if (reposX >= 24 && reposX <= 36 && reposY >= 2 && reposY <= 17) {
				Debug.Log("ポジション変更2");
				Destroy (stone2);
				Destroy (_stone2);
				GameObject newGameObject = Instantiate(newPrefab2) as GameObject;
				PL.transform.position = new Vector3(30, 2, -2);
			}
					isFadeIn = true;
		}
	}
 
	void SetAlpha(){
		fadeImage.color = new Color(red, green, blue, alfa);
	}
}
