using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderManager : MonoBehaviour
{       
    public void SceneLoader(string nameScene) 
    {
        SceneManager.LoadScene(nameScene);
    }
    public void SceneLoader(int indexScene) 
    {
        SceneManager.LoadScene(indexScene);
    }
}
