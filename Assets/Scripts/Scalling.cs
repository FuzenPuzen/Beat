using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalling : MonoBehaviour
{
    [SerializeField] private float yScale;
    [SerializeField] private float scaleSpeed;
    float buff;
    void Start()
    {
        buff = yScale;
    }

    void Update()
    {
        
    }

    public void StartScalling()
    {
        StartCoroutine(Scaling());
    }

    public IEnumerator Scaling()
    {
        while (transform.localScale.y <= yScale)
        {
            transform.localScale += new Vector3(0, scaleSpeed * Time.deltaTime, 0);
            yield return null;
        }
        SwitchDirection(1);
    }

    public IEnumerator DeScaling()
    {
        while (transform.localScale.y >= 1)
        {
            transform.localScale -= new Vector3(0, scaleSpeed * Time.deltaTime, 0);
            yield return null;
        }
        //SwitchDirection(2);
    }

    public void SwitchDirection(int _i)
    {
        if (_i == 1)
        {
            StartCoroutine(DeScaling());
        }
        else
        {
            StartCoroutine(Scaling());
        }
    }
}
