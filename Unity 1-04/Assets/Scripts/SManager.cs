using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SManager : MonoBehaviour
{
    public GameObject prefabImage;

    void Start()
    {
        CreateMolly();
    }
    
    public void CreateMolly()
    {
        if (Global.molecount > 20) return;

        StartCoroutine(CreateObject());
    }

    IEnumerator CreateObject()
    {
        float x = Random.Range(-7, 7);
        float y = Random.Range(-4, 4);
        Instantiate(prefabImage, new Vector2(x, y), Quaternion.identity);

        Global.molecount++;

        yield return null;
    }
}
