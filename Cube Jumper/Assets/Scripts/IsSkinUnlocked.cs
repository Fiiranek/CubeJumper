using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsSkinUnlocked : MonoBehaviour
{
    public string isUnlocked;
    public GameObject skinCheckMark;

    public void CheckIfUnlocked()
    {
        isUnlocked = PlayerPrefs.GetString("Unlocked" + this.gameObject.name);
        if (isUnlocked == "")
        {
            isUnlocked = "false";
        }
        if (isUnlocked == "true")
        {
            skinCheckMark.SetActive(true);
        }
        if (isUnlocked == "false")
        {
            skinCheckMark.SetActive(false);
        }
        if(this.gameObject.name == "Skin1")
        {
            skinCheckMark.SetActive(true);
            PlayerPrefs.SetString("Unlocked" + this.gameObject.name,"true");
            PlayerPrefs.Save();
        }
    }

    void Start()
    {
        CheckIfUnlocked();
    }
}
