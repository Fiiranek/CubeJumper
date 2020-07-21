using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinsPosition : MonoBehaviour
{
    public RectTransform skin1;
    public RectTransform skin2;
    public RectTransform skin3;
    public RectTransform skin4;
    public RectTransform skin5;
    public RectTransform skin6;
    public RectTransform skin7;
    public RectTransform skin8;
    public RectTransform skin9;
    public RectTransform skin10;
    public RectTransform skin11;
    public RectTransform skin12;
    public RectTransform homeBtn;
    public Image coinIcon;
    public Text coins;

    void Start()
    {
        int widthGrid = Screen.width / 10;
        int heightGrid = Screen.height / 10;
        float hGrid = Screen.height / 10;
        float wGrid = Screen.width / 6;
        skin1.position = new Vector2(wGrid * 1, hGrid * 7);
        skin2.position = new Vector2(wGrid * 3, hGrid * 7);
        skin3.position = new Vector2(wGrid * 5, hGrid * 7);
        skin4.position = new Vector2(wGrid * 1, hGrid * 5);
        skin5.position = new Vector2(wGrid * 3, hGrid * 5);
        skin6.position = new Vector2(wGrid * 5, hGrid * 5);
        skin7.position = new Vector2(wGrid * 1, hGrid * 3);
        skin8.position = new Vector2(wGrid * 3, hGrid * 3);
        skin9.position = new Vector2(wGrid * 5, hGrid * 3);
        skin10.position = new Vector2(wGrid * 1, hGrid * 5);
        skin11.position = new Vector2(wGrid * 3, hGrid * 5);
        skin12.position = new Vector2(wGrid * 5, hGrid * 5);
        homeBtn.position = new Vector2(Screen.width / 2, hGrid * 1);
        coinIcon.rectTransform.position = new Vector2(widthGrid * 1, heightGrid * 9);
        coins.rectTransform.position = new Vector2(widthGrid * 3, heightGrid * 9);
        UpdateCoinsCount();
    }

    void UpdateCoinsCount()
    {
        int coinsCount = PlayerPrefs.GetInt("Coins");
        coins.text = coinsCount.ToString();
    }
}
