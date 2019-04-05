using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Talk_Y1 : MonoBehaviour 
{
	public GameObject Panel;
    private Conversation_Y1 conversation;
	public List<GameObject> EnemyList;
    public Text text;
    public GameObject Chara;
    public int num;
	float TimeCount　= 1;

    public string nextSceneName;

    // Use this for initialization
    void Start()
    {
        //パネルを非表示に
        Panel.SetActive(false);
        //会話カウントの初期値
        num = 0;

        conversation = GetComponent<Conversation_Y1>();
    }


    // Update is called once per frame
    void Update()
    {
       // Time.timeScale = 0f;

		TimeCount -= Time.deltaTime;
        //接触状態でクリックでパネル表示
        if(TimeCount <= 0 && num < conversation.rowLength)
        {
            Panel.SetActive(true);
		}

        //会話
        if (Input.GetKeyDown(KeyCode.Return))
        {

            //テキストの書き換え
			//conversation = GetComponent<Conversation_Y1>();
            text.text = conversation.splitText[num];
            num++;

            //会話が最後なら終了
            if (num　== conversation.rowLength)
            {

                Panel.SetActive(false);
				 foreach(GameObject g in EnemyList){
				g.SetActive(true);
                }
                Chara.SetActive(false);
                SceneManager.LoadScene (nextSceneName, LoadSceneMode.Single);
             //   Time.timeScale = 1f;
            }
        }
	}
}
