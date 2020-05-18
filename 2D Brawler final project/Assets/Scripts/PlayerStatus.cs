using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
           // int rand = Random.Range(0, obstaclePatterns.Length);

            timeBtwSpawn = startTimeBtwSpawn; // resets timer
            if (startTimeBtwSpawn > minTime) //Change to reduce time to 
            {
                startTimeBtwSpawn -= decreaseTime;
            }

        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
