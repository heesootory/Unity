using UnityEngine;

public class ImageScript2 : MonoBehaviour
{

    public SpriteRenderer renderer1 = null;
    public SpriteRenderer renderer2 = null;
    public Sprite changeImage = null;

    void Start()
    {
        GameObject obj = GameObject.Find("Image 1");
        renderer1 = obj.GetComponent<SpriteRenderer>();

        renderer1.sprite = changeImage;
        renderer2.sprite = changeImage;


    }


}
