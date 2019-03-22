using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour {
    public GameObject Panel;
	public int count = 0;
    float alfa;
    float speed = 0.01f;
    float red, green, blue;
    //Image fadeImage;  

    void Start () {
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
    }
    void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
			count += 1;
		}
		if (count == 37) 
        {
            Panel.SetActive(false);
            //fadeImage.enabled = true; 
			GetComponent<Image>().color = new Color(red, green, blue, alfa);
			alfa += speed;
			if (alfa == 1) {
				//ここに喜さんの移動と暗転の解除を記入予定
			}
        }
    }
}