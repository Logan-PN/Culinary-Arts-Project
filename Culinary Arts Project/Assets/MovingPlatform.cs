using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class HMovingPlatform : MonoBehaviour
{
    [SerializeField]
    Vector3 platformRange = new Vector3(1, 0, 0);
    [SerializeField]
    float platformTime = 1.0f;
    Rigidbody2D rb;
    float timer = 0f;
    Vector3 destination1;
    Vector3 destination2;
    Vector3 dest;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // initiate timer
        // platform checks its own position
        float startPos = rb.transform.position.x;
        // calculate end positions using startposition and platform range
        destination1 = rb.transform.position + platformRange;
        destination2 = rb.transform.position - platformRange;
        dest = destination1;
    }

    // Update is called once per frame
    void Update()
    {
        // platform moves to the right until it's reached the end of its range
        float speed = platformRange.magnitude * Time.deltaTime;
        if (timer == 0f)
        {
            transform.position = Vector3.MoveTowards(transform.position, dest, speed);
        }
        //rb.velocity = 1 * platformSpeed;
        // plafrom stops for ?? seconds then moves left until range limit is reached
        if(transform.position == destination1 || transform.position == destination2)
        {
            timer += Time.deltaTime;
            if (timer > platformTime)
            {
                //go the other way
                if (dest == destination1)
                {
                    dest = destination2;
                }
                else
                {
                    dest = destination1;
                }
                timer = 0;
            }
        }
        // repeat
    }
}
