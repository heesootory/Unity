using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNext : MonoBehaviour
{
    public void NextScene(string _scene)
    {
        SceneManager.LoadScene(_scene);
    }
}
