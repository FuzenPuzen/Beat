using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equlizer : MonoBehaviour
{
    [Range(0,1)] 
    [SerializeField] float speed;
    [SerializeField] List<GameObject> beats;
    
    int i;
    int k;

    void Start()
    {
        i = -1;
        k = 4;
        StartCoroutine(Timer());
    }


    public void Replay()
    {
        i = -1;
        StartCoroutine(Timer());
    }

    public void MultiReplay()
    {
        StartCoroutine(RecurcionTime());
    }

    public IEnumerator RecurcionTime()
    {
        yield return new WaitForSeconds(4f);
        if (k > 0)
        { 
            MultiReplay();
            Replay();
            k--;
        }
    }

    public void Go()
    {
        beats[i].GetComponent<Scalling>().StartScalling();
        StartCoroutine(Timer());
    }

    public IEnumerator Timer()
    {
        yield return new WaitForSeconds(speed);
        if (i < transform.childCount)
        {
            i++;
            Go();
        }
    }
}
