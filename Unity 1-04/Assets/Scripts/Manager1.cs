using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager1 : MonoBehaviour
{
    public GameObject original;

    void Start()
    {
        Debug.Log(name + " 스타트");
        CreateMolly();
    }

    public void CreateMolly()
    {
        Debug.Log(name + " 크리에이트");
        StartCoroutine(CreateObject());
    }

    IEnumerator CreateObject()  //새로운 두더지 복제 - 코루틴으로 구현해야 개별 프로세스로 관리가 가능해서 더 사용하기 편리하다(그냥 함수로 구현해도 동작은 동일)
    {
        float x = Random.Range(-7, 7);
        float y = Random.Range(-4, 4);
        Instantiate(original, new Vector2(x, y), Quaternion.identity);
        Debug.Log("복제 " + original);

        yield return null;
    }
}
