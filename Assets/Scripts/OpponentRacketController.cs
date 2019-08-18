using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentRacketController : RacketControllerBase
{
    const float velocity = 5f;

    // Update is called once per frame
    void Update()
    {
        GameObject ball = GameObject.Find("Ball");
        Vector3 direction = new Vector3(0, ball.transform.position.y - transform.position.y, ball.transform.position.z - transform.position.z);
        if (direction.magnitude < 1) MoveWithForce(direction * direction.magnitude);
        else MoveWithForce(direction.normalized);
    }
}
