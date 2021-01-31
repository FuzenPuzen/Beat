using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equlizer : MonoBehaviour
{
    [SerializeField] List<GameObject> beats;
    int i;

    void Start()
    {
        i = -1;
        StartCoroutine(Timer());
    }


    public void replay()
    {
        i = -1;
        StartCoroutine(Timer());
    }
    public void Go()
    {
        beats[i].GetComponent<Scalling>().StartScalling();
        StartCoroutine(Timer());
    }

    void Update()
    {
        
    }

    public IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.2f);
        i++;
        Go();
    }
}
