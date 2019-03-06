using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomController : MonoBehaviour {

	private Camera cam;
	private float zoom;
	private float view;

	void Start () {
		cam = GetComponent<Camera> ();
		view = cam.fieldOfView;
	}

	void Update () {
		cam.fieldOfView = view + zoom;

		// 最小値と最大値を決める（自由に変更可能）
		if (cam.fieldOfView < 2f) {
			cam.fieldOfView = 2f;
		}

		// 「自分の主観カメラ」を基準に数値を決めてください。
		if(cam.fieldOfView > 5f){
			cam.fieldOfView = 5f;
		}

		// リターンキーを押すと、zoomの数値が減少（ボタンは自由に変更可能）
		if (Input.GetKey (KeyCode.Return)) {

			// どれくらいの速度でzoomを変更させるかも自由です。
			zoom -= 0.3f;

			// 右シフトキーを押すと、zoomの数値が増加（ボタンは自由に変更可能）
		} else if (Input.GetKey (KeyCode.RightShift)){
			zoom += 0.3f;
		}
	}
}