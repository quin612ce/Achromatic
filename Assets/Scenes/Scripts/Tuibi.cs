using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuibi : MonoBehaviour {
	private GameObject player;
	public GameObject bullet;
	private float targetTime = 1.0f;
	private float currentTime = 0;
	//弾を保存しておくリスト
	private List<GameObject> list = new List<GameObject>();

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		//弾を1秒ごとに打ち出すためのもの
		currentTime += Time.deltaTime;
		if (targetTime < currentTime) {
			currentTime = 0;
			//敵の位置を保存
			var pos = this.gameObject.transform.position;
			var t = Instantiate (bullet) as GameObject;
			//リストに弾を保存しておく
			list.Add(t);
			//弾の初期位置を敵の位置にする
			t.transform.position = pos;
		}
		//リストから一つずつ弾を取り出してベクトルの向きを修正する
		foreach (var l in list) {
			l.GetComponent<Rigidbody2D> ().velocity = (player.transform.position - l.transform.position).normalized * 3;
			Debug.Log (l.GetComponent<Rigidbody2D> ().velocity);
		}
	}
}
