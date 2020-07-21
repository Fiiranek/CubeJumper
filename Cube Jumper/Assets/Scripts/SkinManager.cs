using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer skin = this.gameObject.GetComponent<SpriteRenderer>();
        string currentSkin = PlayerPrefs.GetString("Skin");
        if (currentSkin == "") PlayerPrefs.SetString("Skin", "Skin1");
        PlayerPrefs.Save();
        currentSkin = PlayerPrefs.GetString("Skin");
        Debug.Log(currentSkin);
        skin.sprite = Resources.Load<Sprite>(currentSkin);
    }

}
