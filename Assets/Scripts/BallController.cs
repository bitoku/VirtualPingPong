using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    float velocity_limit = 200f;
    const float force = 20f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(velocity_limit, Random.Range(-10f, 10f), Random.Range(-10f, 10f));
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 velocity = GetComponent<Rigidbody>().velocity;

        if (collision.gameObject.tag == "Self")
        {
            velocity_limit += force;
            velocity.x = -velocity_limit;
        }
        else if (collision.gameObject.tag == "Opponent")
        {
            velocity_limit += force;
            velocity.x = velocity_limit;
        }
        else
        {
            velocity.x = Mathf.Sign(velocity.x) * velocity_limit;
        }

        GetComponent<Rigidbody>().velocity = velocity;

    }
}
