using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDesink : MonoBehaviour
{
    [SerializeField] float time;
    void Start()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(time);
        transform.GetComponent<Animator>().enabled = true;
    }

}
