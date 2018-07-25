using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dialogueUI;
    public Text dialogueText;

    public bool dialogueActive;

    public string[] dialogueLines;

    public int currentLine;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            // dialogueUI.SetActive(false);
            // dialogueActive = false;

            currentLine++;
        }

        if(currentLine >= dialogueLines.Length)
        {
            dialogueUI.SetActive(false);
            dialogueActive = false;

            currentLine = 0;

        }

        dialogueText.text = dialogueLines[currentLine];
	}

    public void showBox(string dialogue)
    {
        dialogueActive = true;
        dialogueUI.SetActive(true);
        dialogueText.text = dialogue;
    }

    public void showDialogue()
    {
        dialogueActive = true;
        dialogueUI.SetActive(true);
    }
}
