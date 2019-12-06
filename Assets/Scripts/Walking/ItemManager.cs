using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ItemManager : MonoBehaviour
{
    public int cnt = 0;
    public Dialogue dialogue;

    void update()
    {
        if (cnt >= 5)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else Debug.Log(cnt);
            
    }
}
