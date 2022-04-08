using System.Linq.Expressions;
using UnityEngine;

public class ObjectCycle : MonoBehaviour{

    int index = 0;


    void Update()
    {
        print(string.Format("{0}. Update", ++index));
    }

    //void LateUpdate()
    //{
    //    print(string.Format("{0}. LateUpdate", --index));
    //}

    //void FixedUpdate()
    //{
    //    print(string.Format("{0}. FixedUpdate", ++index));
    //}
}
