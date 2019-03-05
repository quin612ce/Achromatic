using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ときどき、範囲内にランダムにプレハブを作る
public class RandomTrap1 : MonoBehaviour {

	public GameObject newPrefab; // 作るプレハブ：Inspectorで指定
	public float intervalSec = 4; // 作成間隔（秒）：Inspectorで指定する

	void Start() { // 最初に行う
		// 指定秒ごとに、CreatePrefabをくり返し実行する予約
		InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
	}

	void CreatePrefab() {
		// このオブジェクトの範囲内にランダムに

		Vector3 newPos = this.transform.position;
		newPos.x += Random.Range(-45, -5);
		newPos.y += Random.Range(9, 12);
		newPos.z = -5; // 手前に表示
		// プレハブを作る
		GameObject newGameObject = Instantiate(newPrefab) as GameObject;
		newGameObject.transform.position = newPos;

	}
}

