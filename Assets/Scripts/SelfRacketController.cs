using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRacketController : RacketControllerBase
{
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W)) direction += UP;
        if (Input.GetKey(KeyCode.A)) direction += LEFT;
        if (Input.GetKey(KeyCode.S)) direction += DOWN;
        if (Input.GetKey(KeyCode.D)) direction += RIGHT;
        Move(direction.normalized);
    }
}
