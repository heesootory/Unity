using UnityEngine;

public class Manager : MonoBehaviour
{
    public Sprite[] spritesA = new Sprite[16];
    public Sprite[] spritesB = new Sprite[16];
    private SpriteRenderer renderer1 = null;
    private SpriteRenderer renderer2 = null;
    private int i = 0;

    void Start()
    {
        GameObject obj1 = GameObject.Find("Image 1");
        GameObject obj2 = GameObject.Find("Image 2");
        renderer1 = obj1.GetComponent<SpriteRenderer>();
        renderer2 = obj2.GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            renderer1.sprite = spritesA[i % 16];
            renderer2.sprite = spritesB[i % 16];
            i++;
        }

    }
}
