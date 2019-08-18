using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketControllerBase : MonoBehaviour
{
    const float velocity = 200f;
    protected Vector3 UP = new Vector3(0, 1, 0);
    protected Vector3 LEFT = new Vector3(0, 0, -1);
    protected Vector3 DOWN = new Vector3(0, -1, 0);
    protected Vector3 RIGHT = new Vector3(0, 0, 1);
    private const float margin = velocity;

    protected void Move(Vector3 direction)
    {
        GetComponent<Rigidbody>().velocity = direction * velocity;
    }

    protected void MoveWithForce(Vector3 direction)
    {
        GetComponent<Rigidbody>().AddForce(direction * velocity);
    }
}
