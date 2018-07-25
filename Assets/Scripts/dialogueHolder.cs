using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueHolder : MonoBehaviour {

    private DialogueManager dialogueManager;

    //public string dialogue;

    public string[] dialogueLines;


	// Use this for initialization
	void Start () {
        dialogueManager = FindObjectOfType<DialogueManager>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
      if(other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                // dialogueManager.showBox(dialogue);
                if (!dialogueManager.dialogueActive)
                {
                    dialogueManager.dialogueLines = dialogueLines;
                    dialogueManager.currentLine = 0;
                    dialogueManager.showDialogue();
                }
            }
        } 
    }
}
