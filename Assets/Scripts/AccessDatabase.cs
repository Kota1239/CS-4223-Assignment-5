using UnityEngine;
using System.Collections;
using TMPro;

public class AccessDatabase : MonoBehaviour
{
    public string url = "http://localhost/updateScore.php";

    IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;
        string result = www.text;
        print("Data: " + result);
        GameObject.Find("ScoresText").GetComponent<TMP_Text>().text = result;
    }

    public void Update()
    {
        
    }
}
