using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinUIPosition : MonoBehaviour
{
    public RectTransform nextLvlBtnTransform;
    public Button nextLvlBtn;
    public Text COMPLETED;
    public Text level;
    public Text nextLvlText;
    
    void PositionWinUI()
    {
        float screenHeight = Screen.height;
        float screenWidth = Screen.width;
        float widthGrid = screenWidth / 10;
        level.rectTransform.position = new Vector2(screenWidth / 2, screenHeight * 0.8f);
        level.text = "LEVEL " + SceneManager.GetActiveScene().name;
        COMPLETED.rectTransform.position = new Vector2(screenWidth / 2, screenHeight * 0.7f);
        if (SceneManager.GetActiveScene().name == "24")
        {
            nextLvlBtn.enabled = false;
        }
        else
        {
            nextLvlBtnTransform.position = new Vector2(screenWidth / 2, screenHeight * 0.5f);
            nextLvlText.text = "LEVEL " + (int.Parse(SceneManager.GetActiveScene().name) + 1).ToString();
        }
    }

    void Start()
    {
        PositionWinUI();
    }
}
