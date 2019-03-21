using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winder : MonoBehaviour {
public GameObject bullet;
public GameObject target;

public float GetAim()
    {
        float dx = target.transform.position.x - transform.position.x;
        float dy = target.transform.position.y - transform.position.y;
        return Mathf.Atan2(dx, dy) * Mathf.Rad2Deg;
    }

	// Use this for initialization
	void Start () {
		StartCoroutine (Update_coroutine());
	}
	
	// Update is called once per frame
	IEnumerator Update_coroutine() {
		float baseDirection = GetAim();
        int count = 0;


        while (true)
        {
            // 檻の中心角度を設定。最初の自キャラ角度を中心として＋３０度～－３０度の範囲をゆらゆら動かす
            float dir = baseDirection + Mathf.Sin(count * Mathf.Deg2Rad) * 30.0f;

            // 偶数弾を撃つ感じで、自キャラ角度を外して上下３本づつ０．０５秒毎に弾発射
            for (int index = -3; index < 3; index++)
            {
                Instantiate(bullet, this.transform.position, Quaternion.Euler (this.transform.rotation.eulerAngles+ new Vector3(0, 0, dir + index * 30 + 15)));
            }
            yield return new WaitForSeconds(0.4f);
            count++;
		}
	}
}
