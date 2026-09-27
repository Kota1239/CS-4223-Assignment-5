using UnityEngine;
using System.Collections;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField scoreInput;

    public void saveScore()
    {
        StartCoroutine(UploadToPHP(nameInput.text, int.Parse(scoreInput.text)));
    }

    public IEnumerator UploadToPHP(string name, int score)
    {
        //yield return new WaitForSeconds(1);
        string url = "http://localhost/updateScore_b.php";
        url += "?name=" + name + "&score=" + score;
        WWW www = new WWW(url);
        yield return www;
        print("Saved score of " + score + " for " + name);
        GameObject.Find("SceneController").GetComponent<Scenes>().EndPlay();
    }
}
