
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneLoader : MonoBehaviour
{

    public void LoadRandomScene()
    {
        int index = Random.Range(4, 6);
        SceneManager.LoadScene(index);
    }
    

   
}