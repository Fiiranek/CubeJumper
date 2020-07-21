using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseUIPosition : MonoBehaviour
{
    public RectTransform skinImage;
    public RectTransform yesBtn;
    public RectTransform noBtn;
    public RectTransform purchaseText;
    public Text coins;
    int coinsCount;

    // Start is called before the first frame update
    void Start()
    {
        float widthGrid = Screen.width / 10;
        float heightGrid = Screen.height/ 10;
        purchaseText.position = new Vector2(widthGrid*5,heightGrid*8);
        skinImage.position = new Vector2(widthGrid*5,heightGrid*5);
        yesBtn.position = new Vector2(Screen.width/3,heightGrid*3);
        noBtn.position = new Vector2((Screen.width/3)*2,heightGrid*3);
    }

    public void HidePurchaseUI()
    {
        this.gameObject.SetActive(false);
    }

    public void UpdateCoinsCount()
    {
        coinsCount = PlayerPrefs.GetInt("Coins");
        coins.text = coinsCount.ToString();
    }
}
