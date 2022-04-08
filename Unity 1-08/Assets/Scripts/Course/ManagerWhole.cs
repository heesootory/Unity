using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerWhole : MonoBehaviour
{
    public static ManagerWhole singleton;
    public int score = 0;

    void Awake()
    {
        if(singleton == null)
        {
            singleton = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(singleton != this)
        {
            Destroy(gameObject);
        }
    }

    public void print()
    {
        Debug.Log("This method is singleton method.");
        Debug.Log("Now score is " + score);
    }

}
