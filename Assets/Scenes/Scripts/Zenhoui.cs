using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zenhoui : MonoBehaviour {

	//弾のプレハブ
	public GameObject bullet;

	//以下に1秒ごとに弾生成 currect+1s的な？
	private float targetTime = 1.0f;
	private float currentTime = 0;
	//飛ばすタイミングを計るため変数
	private int num = 0;
	//角度で円状に弾を置きたい
	private float deg = 0;
	//弾を作り終えたかどうか
	//330°より大きくなったらおしまい
	bool hasMakeBullet = false;
	//弾オブジェクトについてるスクリプトShotbullet.csコンポーネントを保存する
	private List<Shotbullet> list=new List<Shotbullet>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//1秒ごとに弾をつくる
		currentTime += Time.deltaTime;
		if (targetTime < currentTime) {
			currentTime = 0;
			num++;
			//角度が330°以下なら弾をつくる
			//円周上に弾をつくり終えていないなら弾を作製する
			if (!hasMakeBullet) {
				//角度degからラジアンを作成
				var rad = deg * Mathf.Deg2Rad;
				//ラジアンを用いてsinとcosを求める
				var sin = Mathf.Sin (rad);
				var cos = Mathf.Cos (rad);
				//円周上の点を求める
				//円の中心座標に半径をかけたcosとsinを足す
				var pos = this.gameObject.transform.position + new Vector3 (cos * 2.0f, sin * 2.0f, 0);
				//弾の作成
				var t = Instantiate (bullet) as GameObject;
				//弾をさっき出した円周上の座標に置く
				t.transform.position = pos;
				//弾オブジェクトtからShotbulletコンポネントを取得
				var a=t.GetComponent<Shotbullet>();
				//取得したShotbulletコンポネントをListに加える
				list.Add(a);
				//Shotbulletスクリプト内のCharaposにアクセスして中心座標をセットする
				a.CharaPos = this.gameObject.transform.position;
				//numカウントが20になったら弾を放射線状に飛ばす
			}else if (num == 20)
			{
				//リストから一つずつ各弾のオブジェクトのShotbulletコンポーネントを取り出す
				foreach (var t in list) {
					//Shotbulletコンポネント内のTobu()メソッドを実行
					t.Tobu ();
				}
		}

				//角度を30°足す
				deg += 30;
				//330°よりもおおきくなったら弾は作らないからフラグをtrueに
				if (deg > 330)
					hasMakeBullet = true;
			}
		}
	}