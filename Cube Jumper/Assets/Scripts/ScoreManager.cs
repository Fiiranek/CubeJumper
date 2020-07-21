using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int bestscore = 0;
    public int score = 0;
    public GameManager gm;
    public Text scoreText;
    public Rigidbody2D player;
    public Text scoredScore;
    public Text bestScore;
    public Text BESTSCORE;
    int limit;
    string bestscorePref;
    public GameObject winUI;
    int[] limits = { 15, 20, 25, 35, 40, 50, 60, 70, 75, 80, 85, 90, 95, 100, 105, 120, 130, 140, 150, 160, 170, 180, 190, 200 };
    public Image coinIcon;
    public Text coins;
    AudioSource sound;
    void Start()
    {
        sound = GameObject.Find("SoundObject").GetComponent<AudioSource>();
        int widthGrid = Screen.width / 10;
        int heightGrid = Screen.height / 10;
        limit = limits[int.Parse(SceneManager.GetActiveScene().name) - 1];
        scoreText.rectTransform.position = new Vector2(Screen.width / 2, Screen.height * 0.85f);
        coinIcon.rectTransform.position = new Vector2(widthGrid * 1, heightGrid * 9);
        coins.rectTransform.position = new Vector2(widthGrid * 3, heightGrid * 9);
        bestscorePref =  "Bestscore"+SceneManager.GetActiveScene().name;
        bestscore = PlayerPrefs.GetInt(bestscorePref, bestscore);
        Debug.Log(limit + " to limit");
    }

    public void WinLevel()
    {
        sound.enabled = false;
        scoreText.enabled = false;
        bestscore = score;
        PlayerPrefs.SetString("Completed"+SceneManager.GetActiveScene().name, "true");
        PlayerPrefs.SetString("GameLevel", (int.Parse(SceneManager.GetActiveScene().name) + 1).ToString());
        PlayerPrefs.SetInt(bestscorePref, bestscore);
        PlayerPrefs.Save();
        winUI.SetActive(true);
    }

    public void SetBestScore()
    {
        BESTSCORE.text = "NEW BEST SCORE!";
        bestscore = score;
        bestscore = score;
        PlayerPrefs.SetInt(bestscorePref, bestscore);
        PlayerPrefs.Save();
    }

    void Update()
    {
        scoreText.text = score.ToString();

        if (score >= limit)
        {
            WinLevel();
        }

        if (gm.isGameEnded == true)
        {
            if (score > bestscore)
            {
                SetBestScore();
            }
            bestScore.text = bestscore.ToString() + "/" + limit.ToString();
            scoredScore.text = score.ToString() + "/" + limit.ToString();
        }
    }
}
