using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotbullet : MonoBehaviour {

	//中心座標
	private Vector2 charaPos;
	//charaPosに中心座標をセット (Zenhoui.csで呼び出してる)
	public Vector2 CharaPos { set { charaPos = value; } }
	//弾自身体の座標をセットする変数
	private Vector2 pos;

	// Use this for initialization
	void Start () {
		//弾の始点をセット (Zenhoui.csで始点においてるので自分の位置を取得しているだけ)
		pos = this.gameObject.transform.position;
	}

	public void Tobu()
	{
		this.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (pos.x - charaPos.x, pos.y - charaPos.y);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
