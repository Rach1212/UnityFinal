using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookNumber : MonoBehaviour
{


    public Text BookText;
    private int ScoreNum;


    void Start()
{
    ScoreNum = 0;
    BookText.GetComponent<Text>().text = "Book Collected: " + ScoreNum;

}

}
