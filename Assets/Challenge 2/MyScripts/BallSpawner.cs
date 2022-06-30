using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] balls;
    
    float ballPosX = 0;
    float spawnIntervals = 0;
    void Start()
    {

        spawnIntervals = Random.Range(3, 6);
        InvokeRepeating("spawnBalls", 1, spawnIntervals);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnBalls() 
    {
        ballPosX = Random.Range(-30, 6);
        int randomBalls = Random.Range(0, balls.Length);
        Instantiate(balls[randomBalls], new Vector3(ballPosX, 30, 0f),Quaternion.identity);
    
    }

}
