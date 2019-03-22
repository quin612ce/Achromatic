using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TalkMap1 : MonoBehaviour
{
    public GameObject Panel;
    private Conversation conversation;
    public Text text;
    public int num;
	float TimeCount　= 1;
    public bool TalkEnd = false;


    // Use this for initialization
    void Start()
    {
        //パネルを非表示に
        Panel.SetActive(false);
        Debug.Log("パネルオフ");
        //会話カウントの初期値
        num = 0;
    }


    // Update is called once per frame
    void Update()
    {
		TimeCount -= Time.deltaTime;
        //接触状態でクリックでパネル表示
        if(TimeCount <= 0)
        {
            Panel.SetActive(true);

        }

        //会話
        if (Input.GetKeyDown(KeyCode.Return))
        {

            //テキストの書き換え
			conversation = GetComponent<Conversation>();
            text.text = conversation.splitText[num];
            num++;

            //会話が最後なら終了
            if (num == conversation.rowLength)
            {
                TalkEnd = true;
                Panel.SetActive(false);
				Debug.Log("FirstClear");
            }
        }
    }
}