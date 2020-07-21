using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsUpdater : MonoBehaviour
{
    public void UpdateCoinsCount()
    {
        int coinsCount = PlayerPrefs.GetInt("Coins");
        Text coins;
        coins = GameObject.Find("Coins").GetComponent<Text>();
        coins.text = coinsCount.ToString();
    }
}
