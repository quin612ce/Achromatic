using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class TalkP : MonoBehaviour
{
    public GameObject Panel;
    private Conversation conversation;
    public Text text;
    public int num;
	float TimeCount　= 3;
    public bool scenechangeP = false;


    // Use this for initialization
    void Start()
    {
        //パネルを非表示に
        Panel.SetActive(false);
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
                scenechangeP = true;
                Panel.SetActive(false);
				Debug.Log("ToBlack");
				//SceneManager.LoadScene("Prologue_2"); 
            }
        }
    }
}