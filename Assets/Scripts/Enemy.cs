using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private float latestDirectionChangeTime;
    private readonly float directionChangeTime = 5f;
    private float characterVelocity = 5f;
    private Vector2 movementDirection;
    private Vector2 movementPerSecond;


    void Start() {
        latestDirectionChangeTime = 0f;
        calcuateNewMovementVector();
    }

    void calcuateNewMovementVector() {
        movementDirection = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
        movementPerSecond = movementDirection * characterVelocity;
    }

    void Update() {
        //if (Time.time - latestDirectionChangeTime > directionChangeTime) {
        if ((transform.position.x > 30 || transform.position.x < -30) || (transform.position.y > 20 || transform.position.x < -20)) {
            latestDirectionChangeTime = Time.time;
            calcuateNewMovementVector();
        }

        //move enemy: 
        transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime),
        transform.position.y + (movementPerSecond.y * Time.deltaTime));

    }
}
