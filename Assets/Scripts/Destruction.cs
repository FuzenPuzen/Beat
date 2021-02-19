using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    [SerializeField] float timeToDeath;
    void Start()
    {
        StartCoroutine(UntilDestroy());
    }

    private IEnumerator UntilDestroy()
    {
        yield return new WaitForSeconds(timeToDeath);
        Destroy(gameObject);
    }
}
