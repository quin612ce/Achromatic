using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat : MonoBehaviour
{
    public GameObject Panel;
    bool talking;
    bool isStay;
    bool end;
    private LoadText loadText;
    public Text text;
    public int num;


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
        //接触状態でクリックでパネル表示
        if (Input.GetMouseButtonDown(0) && isStay && end)
        {
            Panel.SetActive(true);
            //会話モードON
            talking = true;

        }

        //会話
        if (Input.GetMouseButtonDown(0) && talking)
        {

            //テキストの書き換え
            text.text = loadText.splitText[num];
            num++;

            //会話が最後なら終了
            if (num == loadText.rowLength)
            {
                Panel.SetActive(false);
                talking = false;
                end = false;
            }
        }

    }


    //接触処理
    void OnTriggerEnter2D(Collider2D col)
    {
        isStay = true;
        end = true;
        loadText = col.GetComponent<LoadText>();
    }


    //接触終了処理
    void OnTriggerExit2D(Collider2D col)
    {
        Panel.SetActive(false);
        isStay = false;
        num = 0;
    }

}