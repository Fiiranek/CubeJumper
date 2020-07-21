using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GOUIPosition : MonoBehaviour
{
    public RectTransform rateBtn;
    public RectTransform soundBtn;
    public RectTransform homeBtn;
    public RectTransform restartBtn;
    public Text level;
    public Text bestScore;
    public Text scoredScore;
    public Text BESTSCORE;

    public void GameOverPosition()
    {
        float screenHeight = Screen.height;
        float screenWidth = Screen.width;
        float widthGrid = screenWidth / 10;
        rateBtn.position = new Vector2(widthGrid * 5, screenHeight * 0.1f);
        soundBtn.position = new Vector2(widthGrid * 3, screenHeight * 0.1f);
        homeBtn.position = new Vector2(widthGrid * 7, screenHeight * 0.1f);
        restartBtn.position = new Vector2(screenWidth / 2, screenHeight * 0.4f);
        BESTSCORE.rectTransform.position = new Vector2(screenWidth / 2, screenHeight * 0.65f);
        bestScore.rectTransform.position = new Vector2(screenWidth / 2, screenHeight * 0.55f);
        scoredScore.rectTransform.position = new Vector2(screenWidth / 2, screenHeight * 0.8f);
        level.rectTransform.position = new Vector2(screenWidth / 2, screenHeight * 0.9f);
        level.text = "LEVEL " + SceneManager.GetActiveScene().name;
    }

    void Start()
    {
        GameOverPosition();
    }
}
