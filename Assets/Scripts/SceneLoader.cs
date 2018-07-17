using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
   
   public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

//    public void FinishGame()
//   {
//        SceneManager.LoadScene(2);
//    }


    public void QuitGame()
    {
        Application.Quit();
    }

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
