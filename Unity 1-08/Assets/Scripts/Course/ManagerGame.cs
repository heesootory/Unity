using UnityEngine;

public class ManagerGame : MonoBehaviour
{
    void Start()
    {
        
        StaticVariable.count += 20;
        StaticVariable.ChangeCount("ManagerGame");

        PlayerPrefs.SetInt("Count", StaticVariable.count);

        int bestscore = PlayerPrefs.GetInt("Best Score", 0);
        Debug.Log(string.Format("Best Score is {0}", bestscore));
        Debug.Log("Best Score Load @ ManagerGame");

        ManagerWhole.singleton.score += 10;
        ManagerWhole.singleton.print();
    }
}
