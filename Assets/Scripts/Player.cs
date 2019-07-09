using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        if (input > 0f)
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
        else if ( input < 0f)
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }
    }
}
