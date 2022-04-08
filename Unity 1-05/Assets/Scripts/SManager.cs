using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SManager : MonoBehaviour
{

    public GameObject pHole1, pHole2;

    int count = 0;

    void Start()
    {
        CreateMole();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = Vector3.forward; 
            RaycastHit2D hit = Physics2D.Raycast(origin, direction);
            if (hit.collider.gameObject.GetComponent<Hole2>() != null) 
                hit.collider.gameObject.GetComponent<Hole2>().Shoot();
        }
    }

    public void CreateMole()
    {
        int cnt = Random.Range(1, 4);
        while (cnt-- > 0) StartCoroutine(CreateMoleClone());
    }

    IEnumerator CreateMoleClone()
    {
        ShowMoleCount(1);

        float x = Random.Range(-7, 7);
        float y = Random.Range(-4, 4);
        Instantiate(Random.Range(0, 100) > 50 ? pHole1 : pHole2, new Vector2(x, y), Quaternion.identity);
        yield return null;
    }

    void ShowMoleCount(int add)
    {
        count += add;
        Debug.Log("Mole Count: " + count);
    }

}
