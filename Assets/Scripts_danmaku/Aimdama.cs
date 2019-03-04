using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aimdama : MonoBehaviour {

	//プレイヤーオブジェクト
	public GameObject Player;

	//弾のプレハブオブジェクト
	public GameObject bullet;

	//一秒ごとに弾を発射するためのもの
	private float targetTime = 1.0f;
	private float currentTime = 0;

	void Update () {
		//1秒ごとに弾を発射する
		currentTime += Time.deltaTime;
		if (targetTime<currentTime) {
			currentTime = 0;
			//敵の座標を変数posに保存
			var pos = this.gameObject.transform.position;
			//弾のプレハブを作成
			var t = Instantiate(bullet) as GameObject;
			//弾のプレハブの位置を敵の位置にする
			t.transform.position = pos;
			//敵からプレイヤーに向かうベクトルをつくる
			//プレイヤーの位置から敵の位置を引く(ベクトルを求める)
			Vector2 vec = Player.transform.position - pos;
			//弾のRigidBody2Dコンポーネントのvelocityに先程求めたベクトルを入れて力を加える
			t.GetComponent<Rigidbody2D>().velocity = vec;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
}
