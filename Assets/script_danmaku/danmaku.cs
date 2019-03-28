using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Rigidbody2Dコンポーネントを必須にする
[RequireComponent(typeof(Rigidbody2D))]
public class danmaku : MonoBehaviour
{
	//機体の移動速度
	public float Normalspeed;

	public float Slowspeed;

	//弾射出の間隔
	public float shotDelay;

	//弾のPrefabを収納
	public GameObject bullet;

	//弾を打つかどうか(チュートリアルにあったから入れたけど多分使わない)
	public bool canShot;

	//爆発のPredab
	public GameObject explosion;

	//爆発(死亡アニメーション)の作成
	public void Explosion ()
	{
		Instantiate (explosion, transform.position, transform.rotation);
	}

	//下が弾の生成部分(・８・)
	public void Shot (Transform origin) {

		Instantiate (bullet, origin.position, origin.rotation);
	}
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//if(Input.GetKey(KeyCode.LeftShift)){
		//	GetComponent<Rigidbody2D>().velocity =  * Slowspeed;
		//	}

		}
	}
