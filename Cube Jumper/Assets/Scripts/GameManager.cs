using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameEnded = false;
    public GameObject gameOverUI;
    public Text score;
    public PlayerManager pm;
    public GameObject obstacle;
    public GameObject coin;
    public int space = 3;
    public AudioSource sound;
    Text coins;
    Image coinsIcon;
   
    Color[] colors = {
        new Color32(191,63,63,0),
        new Color32(191,127,63,0),
        new Color32(191,191,63,0),
        new Color32(127,191,63,0),
        new Color32(63,191,63,0),
        new Color32(63,191,127,0),
        new Color32(63,191,191,0),
        new Color32(63,127,191,0),
        new Color32(63,63,191,0),
        new Color32(127,63,191,0),
        new Color32(191,63,191,0),
        new Color32(191,63,127,0),
        new Color32(191,63,63,0),
        new Color32(191,127,63,0),
        new Color32(191,191,63,0),
        new Color32(127,191,63,0),
        new Color32(63,191,63,0),
        new Color32(63,191,127,0),
        new Color32(63,191,191,0),
        new Color32(63,127,191,0),
        new Color32(63,63,191,0),
        new Color32(127,63,191,0),
        new Color32(191,63,191,0),
        new Color32(191,63,127,0),
    };
    int[] limits = { 15, 20, 25, 35, 40, 50, 60, 70, 75, 80, 85, 90, 95, 100, 105, 120, 130, 140, 150, 160, 170, 180, 190, 200 };
    int[] coinsCounts = { 3,4, 6, 7, 8, 9, 10, 12, 14, 15, 17, 19, 21, 24, 27, 29, 31, 33, 36, 38, 40, 42, 44, 46 };
    int limit;
    Vector3 worldDimensions;

    void Start()
    {
        worldDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 10));
        Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        coins = canvas.transform.Find("Coins").GetComponent<Text>();
        coinsIcon = canvas.transform.Find("CoinIcon").GetComponent<Image>();
        GenerateCoins();
        GenerateObstacles(limit);
        GenerateBorders(limit);
    }

    public void GenerateObstacles(int count)
    {
        float border = worldDimensions.x + 0.5f;
        Debug.Log("border: "+border);
        for (int i = 0; i < count; i++)
        {
            Instantiate(obstacle, new Vector3(Random.Range(-border, border), space, 0), Quaternion.identity);
            space += 5;
        }
    }

    public void GenerateBorders(int limit)
    {
        float border = worldDimensions.x+0.25f;
        int height = limit * 5;
        GameObject rightBorder = GameObject.Find("RightBorder");
        GameObject leftBorder = GameObject.Find("LeftBorder");
        rightBorder.transform.localScale = new Vector2(0.5f,limit*5);
        leftBorder.transform.localScale = new Vector2(0.5f,limit*5);
        rightBorder.transform.position = new Vector2(border, height/2);
        leftBorder.transform.position = new Vector2(-border, height/2);
    }

    public void GenerateCoins()
    {
        float border = worldDimensions.x;
        limit = limits[int.Parse(SceneManager.GetActiveScene().name) - 1];
        int coinsCount = coinsCounts[int.Parse(SceneManager.GetActiveScene().name) - 1];
        Camera.main.backgroundColor = colors[int.Parse(SceneManager.GetActiveScene().name) - 1];
        float[] coinsX = new float[coinsCount];
        float[] coinsY = new float[coinsCount];

        int yRange = limit*5 / coinsCount;

        for(int i = 1; i < coinsCount + 1; i++)
        {
            coinsY[i - 1] = Random.Range((i - 1) * yRange, i * yRange);
            coinsX[i - 1] = Random.Range(-border+1, border-1);
        }

        for (int i = 0; i < coinsCount; i++)
        {
            Instantiate(coin, new Vector2(coinsX[i], coinsY[i]),Quaternion.identity);
            Debug.Log(i+":    "+coinsY[i]);
        }
        
            
    }

    public void GameOver()
    {
        if (isGameEnded == false)
        {
            coins.enabled = false;
            coinsIcon.enabled = false;
            score.enabled = false;
            sound.enabled = false;
            gameOverUI.SetActive(true);
            pm.enabled = false;
            isGameEnded = true;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
