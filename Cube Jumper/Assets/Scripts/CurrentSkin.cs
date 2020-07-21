using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentSkin : MonoBehaviour
{
    public GameObject isCurrentSkin;

    public void SetCurrentSkin()
    {
        if (PlayerPrefs.GetString("Skin") == "")
        {
            PlayerPrefs.SetString("Skin", "Skin1");
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetString("Skin") == this.gameObject.transform.parent.name)
        {
            isCurrentSkin.SetActive(true);
        }
        else if (PlayerPrefs.GetString("Skin") != this.gameObject.transform.parent.name)
        {
            isCurrentSkin.SetActive(false);

        }
    }

    void Start()
    {
        Debug.Log(PlayerPrefs.GetString("Skin"));
    }

    void Update()
    {
        SetCurrentSkin();
    }
}
