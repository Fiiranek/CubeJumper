using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleManager : MonoBehaviour
{
    bool right = true;
    float border;
    float[] speeds = { 4, 4.5f, 5, 5.2f, 5.5f, 5.7f, 5.9f, 6.1f, 6.3f, 6.5f, 6.7f, 6.9f, 7.1f, 7.2f, 7.3f, 7.4f, 7.5f, 7.6f, 7.7f, 7.8f, 8, 8.1f, 8.2f, 8.3f };

    void Start()
    {
        Vector3 worldDimensions = worldDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 10));
        border = worldDimensions.x;
    }

    public void MoveObstacle(float obstacleSpeed)
    {
        if (right == true)
        {
            transform.Translate(new Vector3(obstacleSpeed * Time.deltaTime, 0, 0));
        }
        if (right == false)
        {
            transform.Translate(new Vector3(-obstacleSpeed * Time.deltaTime, 0, 0));
        }
        if (transform.position.x > border)
        {
            transform.Translate(new Vector3(-obstacleSpeed * Time.deltaTime, 0, 0));
            right = !right;
        }
        if (transform.position.x < -border)
        {
            transform.Translate(new Vector3(obstacleSpeed * Time.deltaTime, 0, 0));
            right = !right;
        }
    }

    void FixedUpdate()
    {
        MoveObstacle(speeds[int.Parse(SceneManager.GetActiveScene().name) - 1]);

    }
}
