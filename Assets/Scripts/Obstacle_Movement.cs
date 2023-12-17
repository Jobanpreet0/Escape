using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Movement : MonoBehaviour
{
    float timer = 0;
    float timerToMove = 0.2f;
    int numOfMovements = 0;
    float speed = 0.36f;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timerToMove)
        {
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            numOfMovements++;
        }

        if(numOfMovements == 14)
        {
            transform.Translate(new Vector3(0, 0f, 0));
            numOfMovements = 0;
            speed = -speed;
        }
    }
}
