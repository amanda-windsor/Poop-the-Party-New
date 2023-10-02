/*
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneLoader : MonoBehaviour
{

    public void LoadRandomScene()
    {
        int index = Random.Range(4, 6);
        SceneManager.LoadScene(index);
    }*/


/*
}*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneLoader : MonoBehaviour
{
    private string[] sceneNames = { "BouncyParty", "RaveParty", "FancyParty" };

    public void LoadRandomScene()
    {
        int randomIndex = Random.Range(0, sceneNames.Length);
        string randomSceneName = sceneNames[randomIndex];
        SceneManager.LoadScene(randomSceneName);
    }
}
