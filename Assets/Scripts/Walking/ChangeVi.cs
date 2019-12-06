using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeVi : MonoBehaviour
{
    
    public void push()
    {
        SceneManager.LoadScene("Village");
    }
}
