using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text timeText;
    float time;

    void Start()
    {
        time = 60.0f;
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        while (time > 0)
        {
            if (time <= 0) break;
            time -= Time.deltaTime;
            timeText.text = string.Format("{0:N2}", time);
            yield return null;
        }

        EndGame();
    }

    public void EndGame()
    {
        TitleManager.gameover = true;

        //스코어 저장 game -> title
        ScoreManager.singleton.Saved();

        //씬 이동
        Game_Manager.SceneToTitle();
    }


    
}
