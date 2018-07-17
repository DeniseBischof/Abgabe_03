using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    
    public GameObject PauseUI;
    public GameObject GameOverUI;
    
    private bool paused = false;

    
    // Use this for initialization
    void Start () {
        PauseUI.SetActive(false);
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;
        }
        
        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
        
        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
        
    }
    
    public void Resume()
    {
        paused = false;
    }

    public void Restart()
    {
        GameOverUI.SetActive(false);
        Application.LoadLevel(Application.loadedLevel); //ich war lazy
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
