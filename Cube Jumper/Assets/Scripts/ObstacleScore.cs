using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScore : MonoBehaviour
{
    public GameObject obstacle;
    GameObject player;
    GameManager gm;

    void Start()
    {
        gm = gameObject.GetComponent<GameManager>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (player.transform.position.y > transform.position.y)
        {
            player.GetComponent<ScoreManager>().score += 1;
            Destroy(GetComponent<ObstacleScore>());
        }
    }
}
