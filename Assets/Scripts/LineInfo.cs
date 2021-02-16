using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineInfo : MonoBehaviour
{
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -30, 0), speed * Time.deltaTime);
        //transform.position += transform.up * -speed * Time.deltaTime;
    }

}
