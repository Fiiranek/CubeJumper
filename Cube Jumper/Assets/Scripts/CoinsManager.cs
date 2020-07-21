using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsManager : MonoBehaviour
{
    public Text coins;
    int coinsCount;
    
    void Start()
    {
        UpdateCoinsCount();
    }

    public void UpdateCoinsCount()
    {
        coinsCount = PlayerPrefs.GetInt("Coins");
        coins.text = coinsCount.ToString();
    }
}
