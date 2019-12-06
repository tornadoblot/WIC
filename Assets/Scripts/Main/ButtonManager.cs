using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sound;
    
    public void Walk()
    {
        AudioSource btn = sound.GetComponent<AudioSource>();
        btn.Play();
        SceneManager.LoadScene("WalkingInit1");

    }

    public void Village()
    {
        AudioSource btn = sound.GetComponent<AudioSource>();
        btn.Play();
        SceneManager.LoadScene("Village");
    }

    public void Point()
    {
        AudioSource btn = sound.GetComponent<AudioSource>();
        btn.Play();
    }

}
