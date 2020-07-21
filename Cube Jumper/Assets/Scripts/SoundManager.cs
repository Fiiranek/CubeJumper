using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public int soundOff;
    public Image soundIcon;
    public Sprite soundOnSprite;
    public Sprite soundOffSprite;

    void Start()
    {
        soundOff = PlayerPrefs.GetInt("SoundOff");
        if (soundOff == 0)
        {
            soundIcon.sprite = soundOnSprite;
        }
        else if (soundOff == 1)
        {
            soundIcon.sprite = soundOffSprite;
        }
    }

    public void SoundToggle()
    {
        if (soundOff == 0)
        {
            PlayerPrefs.SetInt("SoundOff", 1);
            soundIcon.sprite = soundOffSprite;
            soundOff = 1;
        }
        else if (soundOff == 1)
        {
            PlayerPrefs.SetInt("SoundOff", 0);
            soundIcon.sprite = soundOnSprite;
            soundOff = 0;
        }
        PlayerPrefs.Save();
    }
}
