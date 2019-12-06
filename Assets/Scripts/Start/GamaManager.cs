using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamaManager : MonoBehaviour
{
    public Dialogue dialogue;
    private int count = 0;


    // Start is called before the first frame update
    private void Start()
    {
        Invoke("Trigger", 1);
    }

    public void Trigger()
    {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void PushButon()
    {
        count++;
        if(count >= 6)
        {
            SceneManager.LoadScene("Main");
        }

    }
}
