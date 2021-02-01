using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    [SerializeField] GameObject linePb;

    public void SpawnLine()
    {
        Instantiate(linePb, new Vector3(0, 5, 0), Quaternion.identity);
    }

}
