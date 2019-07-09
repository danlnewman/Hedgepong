using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float xspeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f, -speed, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            xspeed = (transform.position.x - collision.transform.position.x) * speed;
            rb.velocity = new Vector3(xspeed, speed, 0.0f);
        }
        else if (collision.transform.CompareTag("Cpu"))
        {
            xspeed = (transform.position.x - collision.transform.position.x) * -speed;
            rb.velocity = new Vector3(xspeed, -speed, 0.0f);
        }
        else if (collision.transform.CompareTag("LeftWall"))
        {
            rb.velocity = new Vector3(-Mathf.Abs(xspeed), rb.velocity.y, rb.velocity.z);
        }
        else if (collision.transform.CompareTag("RightWall"))
        {
            rb.velocity = new Vector3(Mathf.Abs(xspeed), rb.velocity.y, rb.velocity.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.position = new Vector3(0f, 0f, 10f);
        rb.velocity = new Vector3(0.0f, -speed, 0.0f);

    }
}
