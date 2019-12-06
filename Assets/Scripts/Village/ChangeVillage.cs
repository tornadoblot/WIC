using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;

public class ChangeVillage : MonoBehaviour
{
    public GameObject start, end, popup;
    public Button button;
    public Text pointTxt;

    // text
    private TextAsset path;
    string point;
    int pointInt;

    // Start is called before the first frame update
    void Start()
    {
        start.SetActive(true);
        end.SetActive(false);

        path = Resources.Load("data") as TextAsset;

        TextReader txtReader = new StringReader(path.text);
        point = txtReader.ReadLine();

        pointTxt = GameObject.Find("ItemCnt").GetComponent<Text>();
        pointTxt.text = point;

        txtReader.Close();
    }

    public void action()
    {
        pointInt = System.Int32.Parse(point);
        Debug.Log(pointInt);

        if (pointInt < 7) return;
       
        pointInt -= 8;
        pointTxt.text = pointInt.ToString();
        start.SetActive(false);
        end.SetActive(true);
        popup.SetActive(false);
    }
}
