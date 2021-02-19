using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibrate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimeToVib());
    }

    public void Vibrated()
    {
        Handheld.Vibrate();
        StartCoroutine(TimeToVib());
    }

    private IEnumerator TimeToVib()
    {
        yield return new WaitForSeconds(1);
        Vibrated();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
