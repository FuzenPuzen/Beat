using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learping : MonoBehaviour
{
    [SerializeField] Transform endPoint;
    [SerializeField] float speed;

    [SerializeField] Transform startpoint;
    Transform currPoint;

    void Start()
    {
        currPoint = endPoint;
    }

    void Update()
    {
        if (Mathf.Sqrt(Mathf.Pow(currPoint.position.x - transform.position.x, 2) + Mathf.Pow(currPoint.position.y - transform.position.y, 2)) < 0.2f)
        {
            if (currPoint == startpoint)
            {
                currPoint = endPoint;
            }
            else
            {
                currPoint = startpoint;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, currPoint.position, speed * Time.deltaTime);
        //transform.position = Vector3.Lerp(transform.position, currPoint.position, speed * Time.deltaTime);
        transform.Rotate(new Vector3(0,0,2));
    }
}
