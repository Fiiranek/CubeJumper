using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLevel : MonoBehaviour
{
    public GameObject isCurrent;

    public void SetCurrentLevel()
    {
        if (PlayerPrefs.GetString("GameLevel") == "")
        {
            PlayerPrefs.SetString("GameLevel","1");
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetString("GameLevel") == this.gameObject.transform.parent.name)
        {
            isCurrent.SetActive(true);
        }
        else if (PlayerPrefs.GetString("GameLevel") != this.gameObject.transform.parent.name)
        {
            isCurrent.SetActive(false);

        }
    }

    void Start()
    {
        Debug.Log(PlayerPrefs.GetString("GameLevel"));
    }

    void Update()
    {
        SetCurrentLevel();
    }
}
