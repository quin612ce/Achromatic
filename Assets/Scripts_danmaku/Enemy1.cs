using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

	//HP(一応つけてます)
	public int hp = 1;

	//danmakuコンポーネント
	danmaku danmaku;

	IEnumerator Start ()
	{
		danmaku = GetComponent<danmaku> ();

		//ローカル座標のY軸のマイナス方向に移動する
		//Move (transform.up * -1);

		//canshotがfalseの場合ここでコルーチン終了
		if (danmaku.canShot == false) {
			yield break;
		}

		while(true) {

			//子要素をすべて取得してるらしい
			for (int i = 0; i < transform.childCount; i++) {

				Transform shotposition = transform.GetChild (i);

				//shotpositionの位置、角度で弾幕貼る(danmakuスクリプト依存だからそっち見ろ)
				danmaku.Shot (shotposition);
			}
			yield return new WaitForSeconds (danmaku.shotDelay);
		}
	}

	//機体の移動
	public void Move (Vector2 direction)
	{
		GetComponent<Rigidbody> ().velocity = direction * danmaku.speed;
	}

	void OnTriggerEnter2D (Collider2D c)
	{
		//レイヤー名を取得
		string layerName = LayerMask.LayerToName (c.gameObject.layer);

		//レイヤー名がPlayer以外の時は何も行わない
		if (layerName != "Player")
			return;

		//PlayerbulletのTransformを取得(アルフィー的なギミックの時に起こします)
		//Transfrom playerbulletTransform = c.transform.parent;

		//bulletコンポーネントを取得
		//bullet bullet = playerbulletTransform.GetComponent();

		//hpの減少
		//hp = hp - bullet.power;

		//弾の削除
		Destroy (c.gameObject);

		//ヒットポイントが0以下ならば
		if (hp <= 0) {
			
			//エネミーの削除
			Destroy (gameObject);
		}
	}
}