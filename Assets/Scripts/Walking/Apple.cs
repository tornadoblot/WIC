using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    static public int cnt = 5;

    bool is_drag = false;
    float catchballdist;

    public float catchballsped = 1000;
    public Dialogue dialogue;

    void OnMouseDown()
    {
        catchballdist = Vector3.Distance(transform.position, Camera.main.transform.position);
        is_drag = true;

    }

    void onMouseUp()
    {
        is_drag = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (is_drag)
        {
            Debug.Log("isdragon");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 raypoint = ray.GetPoint(catchballdist);
            var tmp = GameObject.Find("ItemManager").GetComponent<ItemManager>();
            tmp.cnt++;
            Debug.Log(tmp.cnt);
            Destroy(this.gameObject);
        }

        if(cnt < 0)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}
