using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public GameObject hi;
    public GameObject hello;

    public Animator animator;
    public GameObject sound;

    public void firstButton()
    {
        SceneManager.LoadScene("WalkingInit2");
    }

    public void secondButton()
    {
        SceneManager.LoadScene("Walking");
    }
}
