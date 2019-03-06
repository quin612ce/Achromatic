using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int hp = 1;

	bullet bullet;

	//☆bullet bltScript;

	//☆public int bPower = bltScript.power;

	danmaku danmaku;

	IEnumerator Start ()
	{
		//danmakuコンポーネント取得
		danmaku = GetComponent<danmaku> ();

		while (true)
		{

			//弾をプレイヤーと同じ位置。角度で生成(アルフィーいたら起こします)
			//danmaku.Shot (transform);

			//ShotDelayを待つ
			yield return new WaitForSeconds (danmaku.shotDelay);
		}


	}
		
		
	// Update is called once per frame
	void Update () {
	
		float x = Input.GetAxisRaw ("Horizontal");

		float y = Input.GetAxisRaw ("Vertical");

		Vector2 direction = new Vector2 (x, y).normalized;

		Move (direction);
	}

	//機体の移動
	void Move (Vector2 direction)
	{
		//画面左下のワールド座標をビューポートから取得
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

		//画面右上のワールド座標をビューポートから取得
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

		//プレイヤーの座標を取得
		Vector2 pos = transform.position;

		//移動量を抑える
		pos += direction * danmaku.speed * Time.deltaTime;

		//プレイヤーの位置が画面内に収まるように制限を掛ける
		pos.x = Mathf.Clamp (pos.x, min.x, max.x);
		pos.y = Mathf.Clamp (pos.y, min.y, max.y);

		//制限をかけた値をプレイヤーの位置にする
		transform.position = pos;
	}

	//ぶつかった瞬間呼び出される
	void OnTriggerEnter2D (Collider2D c)
	{
		//レイヤー名を取得
		string layerName = LayerMask.LayerToName (c.gameObject.layer);

		//レイヤー名がBulletの場合弾を削除
		if (layerName == "Bullet") {
			
		//	int bPower;
		//	bPower = bltScript.power;

			//☆弾幕の座標取得
			//Transform bulletTransform = c.transform.parent;

			//☆bulletコンポーネント取得
			//bullet bullet = bulletTransform.GetComponent<bullet>();

			//☆hp減少
			hp = hp -1;
			Debug.Log(hp);

			//弾の削除
			Destroy (c.gameObject);

			if (hp == 0)
			{

			Destroy (gameObject);
				Debug.Log("Unchi");
			//hpが0以下の時
			//if (hp <= 0)
			//{
			//プレイヤーの削除
			//Destroy (gameObject);
			//}
			//public void Damage( int damage )
			//{
			//hp -= bullet.power;

			//if (0 < hp)
			//return;

			//gameObject.SetActive (false);
			}
		}
	}
}