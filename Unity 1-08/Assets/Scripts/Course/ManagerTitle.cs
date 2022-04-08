using UnityEngine;

public class ManagerTitle : MonoBehaviour
{
    void Start()
    {
        StaticVariable.count = PlayerPrefs.GetInt("Count", 0);
        StaticVariable.ChangeCount("ManagerTitle");

        int bestscore = Random.Range(0, 10000);
        PlayerPrefs.SetInt("Best Score", bestscore);
        Debug.Log("Best Score Save @ ManagerTitle");

        ManagerWhole.singleton.score += 10;
        ManagerWhole.singleton.print();
    }

}
