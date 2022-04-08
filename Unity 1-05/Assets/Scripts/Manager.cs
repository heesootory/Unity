using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = Vector3.forward; // z-axis increase.

            RaycastHit2D hit = Physics2D.Raycast(origin, direction);

            if(hit.collider != null)
            {
                hit.collider.gameObject.GetComponent<Hole2>().Shoot();
            }
        }
    }
}
