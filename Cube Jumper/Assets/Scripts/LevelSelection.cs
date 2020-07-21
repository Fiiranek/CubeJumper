using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelection : MonoBehaviour
{
    public CurrentLevel cl;

    public void SetLevel()
    {
        Debug.Log("klikam");
        PlayerPrefs.SetString("GameLevel", this.gameObject.name);
        PlayerPrefs.Save();
        SSTools.ShowMessage("Level set to " + this.gameObject.name, SSTools.Position.bottom, SSTools.Time.twoSecond);
        cl.SetCurrentLevel();
    }

}
