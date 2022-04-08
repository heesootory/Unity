using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager 
{
    public static void SceneToTitle()
    {
        SceneManager.LoadScene("TitleScene");   //종료 후 씬 이동
    }
}
