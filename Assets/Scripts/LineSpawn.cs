using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineSpawn : MonoBehaviour
{
    [Range (1, 30)]
    [SerializeField] int bubCount;
    [SerializeField] GameObject bubsPb;
    [SerializeField] int freeSpace;
    int startFreeSpace;


    GameObject bubsObj;
    float spawnOffset;
    float spawnStartPoint;
    void Start()
    {
        freeSpace = Random.Range(4, 10);
        startFreeSpace = Random.Range(1, bubCount - freeSpace);
        spawnOffset = bubsPb.GetComponent<SpriteRenderer>().bounds.size.x;
        spawnStartPoint = -3;
        spawnLine();
    }

    public void spawnLine()
    {
        for (int i = 0; i < bubCount; i++)
        {
            if (i < startFreeSpace || i > startFreeSpace + freeSpace)
            {
                bubsObj = Instantiate(bubsPb, transform);
                bubsObj.transform.position = new Vector3(spawnStartPoint + spawnOffset * i, 0, 0);
            }
        } 
    }

}
