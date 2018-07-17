using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    PlayerMovement playerStuff;
    public GameObject GameOverUI;


    public Text bombsText;
    public int bombNum = 0; 

    public Text heartsText;
    public int heartsNum = 3; 



	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {

        bombsText.text = ("" + bombNum); //warum nicht nur int?
        heartsText.text = ("" + heartsNum);

        if(heartsNum <= 0){
            GameOverUI.SetActive(true);
            Time.timeScale = 0;

        }
		
	}
}
