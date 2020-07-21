using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsLevelCompleted : MonoBehaviour
{
    public string isCompleted;
    public GameObject checkMark;

    void Start()
    {
        isCompleted = PlayerPrefs.GetString("Completed"+this.gameObject.name);

        if (isCompleted == "")
        {
            isCompleted = "false";
        }
        if (isCompleted == "true")
        {
            checkMark.SetActive(true);
        }
        if (isCompleted == "false")
        {
            checkMark.SetActive(false);
        }
    }
}
