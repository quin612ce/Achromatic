using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ときどき、範囲内にランダムにプレハブを作る
public class RandomTrap2 : MonoBehaviour {
	public GameObject PL2;
	public float reposX2,reposY2;
	
	public GameObject newPrefab; // 作るプレハブ：Inspectorで指定
	public float intervalSec = 5; // 作成間隔（秒）：Inspectorで指定する

	void Start() { // 最初に行う
		// 指定秒ごとに、CreatePrefabをくり返し実行する予約
		InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
	}

	void Update() {
		PL2 = GameObject.Find("PlayerAnime");
		reposX2 = PL2.transform.position.x;
		reposY2 = PL2.transform.position.y;
	}

	void CreatePrefab() {
		// このオブジェクトの範囲内にランダムに
		if (reposX2 <= 24) {
		Vector3 newPos = this.transform.position;
		newPos.x += Random.Range(reposX2 - 5, reposX2 + 5);
		newPos.y += Random.Range(5, 8);
		newPos.z = -5; // 手前に表示
		// プレハブを作る
		GameObject newGameObject = Instantiate(newPrefab) as GameObject;
		newGameObject.transform.position = newPos;
		}

	}
}

