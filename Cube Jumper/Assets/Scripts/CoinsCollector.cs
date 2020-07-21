using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCollector : MonoBehaviour
{
    Text coins;
    Canvas canvas;
    public CoinsUpdater cu;
    AudioSource sound;

    void Start()
    {
        sound = GameObject.Find("CoinsSound").GetComponent<AudioSource>();
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        coins = canvas.transform.Find("Coins").GetComponent<Text>();
        cu.UpdateCoinsCount();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            
            AddCoin();
        }
    }

    void AddCoin()
    {
        if (PlayerPrefs.GetInt("SoundOff") == 0)
        {
            sound.Play();
        }
        Destroy(this.gameObject);
        int coinsCount = PlayerPrefs.GetInt("Coins");
        coinsCount += 1;
        PlayerPrefs.SetInt("Coins", coinsCount);
        PlayerPrefs.Save();
        cu.UpdateCoinsCount();
    }
}
