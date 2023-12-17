using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_2 : MonoBehaviour
{
    float timer = 0;
    float timerToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.36f;

    void Update()
    {
        timer += Time.deltaTime; //the timer will react to "Time.deltaTime"
        if (timer > timerToMove)
        {
            transform.Translate(new Vector3(speed, 0, 0)); //used to move the gameobject in the direction and distance we need
            timer = 0; //the timer will create a little interval before each move.
            numOfMovements++; //every each movement, the number will add up
        }

        if (numOfMovements == 14) //if the number of movement reaches 14, then transform.translate will reset and the direction will change "speed = -speed"
        {
            transform.Translate(new Vector3(0, 0f, 0));
            numOfMovements = 0;
            speed = -speed;
        }
    }
}
