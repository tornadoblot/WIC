using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnApple : MonoBehaviour
{
    public Transform obj;

    float timeSpan;
    float chkTime;

    // Start is called before the first frame update
    void Start()
    {
        timeSpan = 0.0f;
        chkTime = 3.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSpan += Time.deltaTime;
        if(timeSpan > chkTime)
        {
            Instantiate(obj, new Vector3(-2.3f, -0.2f, -3.5f), Quaternion.identity);
            timeSpan = 0;
        }

        
    }
}
