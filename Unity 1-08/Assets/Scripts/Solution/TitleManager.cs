using UnityEngine;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    public static int title_score;
    public static bool gameover = false;
    public Text savedScore;

    void Start()        
    {
        if (gameover)       //끝
        {
            savedScore.text = "Current Score: " + title_score;
            PlayerPrefs.SetInt("score", title_score);
        }
        else    //시작
        {
            title_score = PlayerPrefs.GetInt("score", 0);
            savedScore.text = "Current Score: " + title_score;
        }
    }
    
}
