using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject origin;

    void Awake()
    {
        Debug.Log("매니저 깨우기 : " + name + " " +  origin);
    }

    void Start()
    {
        Debug.Log("스타트" + origin);
        createMolly();
    }

    public void createMolly()
    {
        print("크리에이트 몰리 " + origin);
        StartCoroutine(change());
    }

    IEnumerator change()
    {
        float x = Random.Range(-7, 7);
        float y = Random.Range(-4, 4);
        Debug.Log("코루틴 : " + origin);
        Instantiate(origin, new Vector2(x, y), Quaternion.identity);
        Debug.Log("복제 완료 : " + origin);
        yield return null;
    }
}
