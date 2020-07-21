using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void LoadCurrentLevel()
    {
        string gameLevel = PlayerPrefs.GetString("GameLevel");
        Debug.Log(gameLevel);
        if(gameLevel=="") SceneManager.LoadScene("1");
        else SceneManager.LoadScene(gameLevel);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("klikam");
    }

    public void LoadLevels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene((int.Parse(SceneManager.GetActiveScene().name) +1).ToString());
    }

    public void LoadSkins()
    {
        SceneManager.LoadScene("Skins");
    }
    
    public void LoadLevels2()
    {
        SceneManager.LoadScene("Levels2");
    }
}
