using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_p1 : MonoBehaviour
{
    public Transform p1, p2;
    public float speed;
    public Transform startPos;

    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == p1.position)
        {
            nextPos = p2.position;
        }
        if(transform.position == p2.position)
        {
            nextPos = p1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
 
}
