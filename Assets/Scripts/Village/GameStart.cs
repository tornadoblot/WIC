using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public Dialogue dialogue;
    int count = 0;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Trigger", 1);
    }

    public void Trigger()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pushBtn()
    {
        count++;
        if (count >= 3) animator.SetBool("IsOpen", true);
    }
}
