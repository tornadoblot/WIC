using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSkip : MonoBehaviour
{

    public void SkipButton()
    {
        SceneManager.LoadScene("Main");
    }
}
