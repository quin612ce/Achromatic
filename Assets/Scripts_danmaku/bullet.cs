using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	public int speed = 10;

	//ゲームオブジェクト生成から削除されるまでの時間
	public float lifeTime = 1;

	//攻撃力
	public int power = 1;

	// Use this for initialization
	void Start () {

		//if (Collision.name.Contains ("Player")) {
		//	var player = Collision.Getcomponent<Player> ();
		//	player.Damage (m_damage);
		//	return;
		//}

		//ローカル座標のY軸方向に移動する
		GetComponent<Rigidbody2D> ().velocity = transform.up.normalized * speed;

		//lifeTime秒後に削除
		Destroy (gameObject, lifeTime);

	}
	// Update is called once per frame
	void Update () {
	}
}