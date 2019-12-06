using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondButton : MonoBehaviour
{

    public void SecondBtn() {
        SceneManager.LoadScene("Walking");
    }
}
