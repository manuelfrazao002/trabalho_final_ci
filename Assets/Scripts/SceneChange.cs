using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string targetSceneName;

    public void LoadTargetScene()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}