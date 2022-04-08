using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioSource audio1 = null;
    public AudioSource audio2 = null;
    public AudioSource audio3 = null;

    void Start()
    {
        GameObject obj = GameObject.Find("Sound 1");
        audio1 = obj.GetComponent<AudioSource>();

        audio2 = gameObject.GetComponent<AudioSource>();

        audio3 = GetComponent<AudioSource>();
    }

}
