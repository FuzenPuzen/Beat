using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineInfo : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += transform.up * -3 * Time.deltaTime;
    }

}
