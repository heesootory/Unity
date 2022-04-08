using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager singleton;
    public int game_score;
    public Text textScore;

    void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (singleton != this) Destroy(gameObject);
    }

    void Start()        //시작 스코어 화면
    {
        game_score = TitleManager.title_score;
        textScore.text = "Score: " + game_score;
    }

    public void ScoreAdd()      //스코어 증가
    {
        game_score += 100;
        textScore.text = "Score: " + game_score;
    }

    public void Saved()     //스코어 저장 game -> title
    {
        TitleManager.title_score = game_score;
    }
}
