using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{

    //　読む込むテキストが書き込まれている.txtファイル
    [SerializeField]
    private TextAsset textAsset;
    private string loadText;
    //　改行で分割して配列に入れる
    public string[] splitText;
    //テキスト内の行数を取得する変数
    public int rowLength;

    // Use this for initialization
    void Start()
    {
        loadText = textAsset.text;
        splitText = loadText.Split(char.Parse("\n"));
        rowLength = splitText.Length;
    }


}