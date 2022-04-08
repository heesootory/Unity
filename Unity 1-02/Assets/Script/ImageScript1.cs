using UnityEngine;

public class ImageScript1 : MonoBehaviour
{
    public GameObject obj1 = null;
    public GameObject obj2 = null;
    public GameObject obj3 = null;


    void Start()
    {
        obj1 = GameObject.Find("Image 1");

        obj2 = GameObject.FindWithTag("Player");
    }

}
