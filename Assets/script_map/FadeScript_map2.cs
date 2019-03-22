using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeScript_map2 : MonoBehaviour {
    public GameObject Panel;
	public int count = 0;
    float alfa;
    float speed = 0.01f;
    float red, green, blue;
    Image fadeImage;  
    public GameObject newPrefab1; // 作るプレハブ：Inspectorで指定
    public GameObject newPrefab2; // 作るプレハブ：Inspectorで指定
	public float reposX1,reposY1,reposX2,reposY2;
	public float intervalSec = 0.5f; // 作成間隔（秒）：Inspectorで指定する

    void Start () {
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
		// 指定秒ごとに、CreatePrefabをくり返し実行する予約
		InvokeRepeating("CreatePrefab1", intervalSec, intervalSec);
        InvokeRepeating("CreatePrefab2", intervalSec, intervalSec);
        reposX1 = -6;
		reposY1 = 0;
		reposX2 = -20;
		reposY2 = 0;
			
    }
    void Update () {
        
		if (Input.GetKeyDown(KeyCode.Return)) {
			count += 1;
		}
		if (count == 19) 
        {
            Panel.SetActive(false);
			Debug.Log("パネル消えて...");
            SceneManager.LoadScene("PlayMap2_second");
            //fadeImage.enabled = true; 
			GetComponent<Image>().color = new Color(red, green, blue, alfa);
			alfa += speed;
			if (alfa == 1) {
				//怒さんの何か？
			}
        }
    }

    void CreatePrefab1() {
		// このオブジェクトの範囲内に
		Vector3 newPos = this.transform.position;
		newPos.x = reposX2 - 2.5f;
		//newPos.y = reposY2 + 2;
		newPos.z = -5; // 手前に表示
		reposX1 = newPos.x;
		reposY1 = newPos.y;
		// プレハブを作る
		if (reposX1 >= -18 && count == 4) {
		GameObject newGameObject = Instantiate(newPrefab1) as GameObject;
		newGameObject.transform.position = newPos;
		}

	}

    void CreatePrefab2() {
		// このオブジェクトの範囲内に
		Vector3 newPos = this.transform.position;
		newPos.x = reposX2 - 2.5f;
		//newPos.y = reposY2 + 2;
		newPos.z = -5; // 手前に表示
		reposX2 = newPos.x;
		reposY2 = newPos.y;
		// プレハブを作る
		if (reposX2 >= -18 && count == 4) {
		GameObject newGameObject = Instantiate(newPrefab2) as GameObject;
		newGameObject.transform.position = newPos;
		}

	}
}