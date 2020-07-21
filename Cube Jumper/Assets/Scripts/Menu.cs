using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    float screenHeight;
    float screenWidth;
    // UI elements
    public RectTransform cubeJumper;
    public RectTransform tapToPlayBtn;
    public RectTransform rateBtn;
    public RectTransform soundBtn;
    public RectTransform infoBtn;
    public RectTransform menuIconBtn;
    public RectTransform levelBtn;
    public Image coinIcon;
    public Text coins;
    public Image skinIcon;
    // screen width and height grids
    float widthGrid;
    float heightGrid;
    string[] sprites;

    void MenuPosition()
    {
        widthGrid = screenWidth / 10;
        heightGrid = screenHeight / 10;
        rateBtn.position = new Vector2(widthGrid*5, heightGrid);
        soundBtn.position = new Vector2(widthGrid*3, heightGrid);
        infoBtn.position = new Vector2(widthGrid*7, heightGrid);
        levelBtn.position = new Vector2(widthGrid*5, heightGrid * 2.5f);
        menuIconBtn.position = new Vector2(widthGrid * 5, heightGrid * 4.5f);
        tapToPlayBtn.position = new Vector2(widthGrid * 5, heightGrid * 6);
        cubeJumper.position = new Vector2(widthGrid * 5, heightGrid * 8);
        coinIcon.rectTransform.position = new Vector2(widthGrid * 1, heightGrid * 9);
        coins.rectTransform.position = new Vector2(widthGrid * 3, heightGrid * 9);
    }

    void Start()
    {
        string currentSkin = PlayerPrefs.GetString("Skin");
        if(currentSkin == "")
        {
            currentSkin = "Skin1";
        }
        skinIcon.sprite = Resources.Load<Sprite>(currentSkin);
        UpdateCoinsCount();
        screenHeight = Screen.height;
        screenWidth = Screen.width;
        MenuPosition();
    }

    void UpdateCoinsCount()
    {
        int coinsCount = PlayerPrefs.GetInt("Coins");
        coins.text = coinsCount.ToString();
    }


}
