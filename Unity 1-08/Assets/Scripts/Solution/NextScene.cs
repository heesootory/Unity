using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void SceneNext(string _scene)
    {
        SceneManager.LoadScene(_scene);
    }
}
