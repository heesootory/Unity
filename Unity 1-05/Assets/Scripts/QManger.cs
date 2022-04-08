using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QManger : MonoBehaviour
{
    public GameObject Hole;

    void Start()
    {
        CreateMolly();
    }

    public void CreateMolly()
    {
        int hole_num = Random.Range(1, 3);
        for (int i = 0; i < hole_num; i++)
        {
            if (Global.clone_molly >= 3)
            {
                Global.clone_molly = 0;
                break;
            }
            StartCoroutine(copy_Molly());
            Global.clone_molly++; Global.total++;
            print(Global.total);
        }
    }
    IEnumerator copy_Molly()
    {
        float x = Random.Range(-7, 7);
        float y = Random.Range(-4, 4);
        Instantiate(Hole, new Vector2(x, y), Quaternion.identity);

        yield return null;
    }

    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Vector3 origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //        Vector3 direction = Vector3.forward;

    //        RaycastHit2D hit = Physics2D.Raycast(origin, direction);

    //        if (hit.collider != null)
    //        {
    //            hit.collider.gameObject.GetComponent<HoleController>().shoot();
    //        }
    //    }
    //}



}
