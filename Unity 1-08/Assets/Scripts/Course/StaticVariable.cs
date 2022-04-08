using UnityEngine;

public class StaticVariable 
{
    public static int count = 0;

    public static void ChangeCount(string _scene)
    {
        ++count;
        Debug.Log(string.Format("{0}'s message : count is {1}", _scene, count));
    }
}
