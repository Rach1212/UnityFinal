using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BookNumber : MonoBehaviour
{

    public int score;
    public TextMeshProUGUI scoreUI;



    void Update()
{
    scoreUI.text = score.ToString();


}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Player")
    {
        
        KeepScore.Score += 1;
        Debug.Log ("Collide penguin and book");
    
    }
    }
}
