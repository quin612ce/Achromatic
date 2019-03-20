using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 範囲内に1秒ごとにプレハブを作る
public class RandomTrap4 : MonoBehaviour {
	public GameObject newPrefab; // 作るプレハブ：Inspectorで指定
	public float reposX2,reposY2;
	public float intervalSec = 0.5f; // 作成間隔（秒）：Inspectorで指定する

	void Start() { // 最初に行う
		// 指定秒ごとに、CreatePrefabをくり返し実行する予約
		InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
		reposX2 = -20;
		reposY2 = 0;
			}

	void CreatePrefab() {
		// このオブジェクトの範囲内に
		Vector3 newPos = this.transform.position;
		newPos.x = reposX2 + 2.5f;
		//newPos.y = reposY2 + 2;
		newPos.z = -5; // 手前に表示
		reposX2 = newPos.x;
		reposY2 = newPos.y;
		// プレハブを作る
		if (reposX2 <= -4) {
		GameObject newGameObject = Instantiate(newPrefab) as GameObject;
		newGameObject.transform.position = newPos;
		}

	}
}

