using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinSelection : MonoBehaviour
{
    public CurrentSkin cs;
    public int price;
    public Text priceText;
    public GameObject purchaseUI;
    public Button yesBtn;
    PurchaseUIPosition pp;
    public IsSkinUnlocked isu;

    void Start() {
        priceText.text = price.ToString();
        GameObject parent = this.gameObject.transform.parent.gameObject.transform.parent.gameObject;
        foreach (Transform child in parent.transform)
        {
            if(child.name == "PurchaseUI")
            {
                purchaseUI = child.gameObject;
            }
        }
        yesBtn = purchaseUI.transform.Find("YES").GetComponent<Button>();
        pp = purchaseUI.GetComponent<PurchaseUIPosition>();
    }

    void TogglePurchaseUI()
    {
        if (purchaseUI.activeSelf == false)
        {
            purchaseUI.SetActive(true);
        }
        else
        {
            purchaseUI.SetActive(false);
        }
    }

    void BuySkin(string isUnlocked,int price,int coins,string skin)
    {
        coins -= price;
        PlayerPrefs.SetInt("Coins",coins);
        isUnlocked = "true";
        PlayerPrefs.SetString("UnlockedSkin" + skin,isUnlocked);
        SSTools.ShowMessage("Unlocked skin " + skin+"!",SSTools.Position.bottom,SSTools.Time.twoSecond);
        PlayerPrefs.Save();
        TogglePurchaseUI();
        pp.UpdateCoinsCount();
        isu.CheckIfUnlocked();
    }

    public void SetSkin()
    {
        string skin = this.gameObject.name;
        int coins = PlayerPrefs.GetInt("Coins");
        string isUnlocked = PlayerPrefs.GetString("UnlockedSkin" + skin);
        if (isUnlocked == "" || isUnlocked == "false")
        {
            if (coins >= price)
            {
                TogglePurchaseUI();
                purchaseUI.transform.Find("PurchaseText").GetComponent<Text>().text = "Purchase for " + price.ToString() + " coins?";
                yesBtn.onClick.AddListener(delegate { BuySkin(isUnlocked, price,coins,skin); });
                purchaseUI.transform.Find("SkinImage").GetComponent<Image>().sprite = Resources.Load<Sprite>("Skin"+skin);
            }
            else
            {
                SSTools.ShowMessage("Not enough coins",SSTools.Position.bottom, SSTools.Time.twoSecond);
            }
        }
        if(isUnlocked == "true")
        {
            PlayerPrefs.SetString("Skin", "Skin"+skin);
            PlayerPrefs.Save();
            SSTools.ShowMessage("Skin set to " + skin, SSTools.Position.bottom, SSTools.Time.twoSecond);
            cs.SetCurrentSkin();
        }
        
    }
}
