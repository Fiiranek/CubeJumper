using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsPosition : MonoBehaviour
{
    public RectTransform level1Btn;
    public RectTransform level2Btn;
    public RectTransform level3Btn;
    public RectTransform level4Btn;
    public RectTransform level5Btn;
    public RectTransform level6Btn;
    public RectTransform level7Btn;
    public RectTransform level8Btn;
    public RectTransform level9Btn;
    public RectTransform level10Btn;
    public RectTransform level11Btn;
    public RectTransform level12Btn;
    public RectTransform homeBtn;
    public RectTransform nextLvlBtn;

    void Start()
    {
        float hGrid = Screen.height / 10;
        float wGrid = Screen.width / 6;
        level1Btn.position = new Vector2(wGrid * 1, hGrid * 9);
        level2Btn.position = new Vector2(wGrid * 3, hGrid * 9);
        level3Btn.position = new Vector2(wGrid * 5, hGrid * 9);
        level4Btn.position = new Vector2(wGrid * 1, hGrid * 7);
        level5Btn.position = new Vector2(wGrid * 3, hGrid * 7);
        level6Btn.position = new Vector2(wGrid * 5, hGrid * 7);
        level7Btn.position = new Vector2(wGrid * 1, hGrid * 5);
        level8Btn.position = new Vector2(wGrid * 3, hGrid * 5);
        level9Btn.position = new Vector2(wGrid * 5, hGrid * 5);
        level10Btn.position = new Vector2(wGrid * 1, hGrid * 3);
        level11Btn.position = new Vector2(wGrid * 3, hGrid * 3);
        level12Btn.position = new Vector2(wGrid * 5, hGrid * 3);
        nextLvlBtn.position = new Vector2(wGrid * 5, hGrid * 1);
        homeBtn.position = new Vector2(Screen.width / 2, hGrid * 1);
    }
}
