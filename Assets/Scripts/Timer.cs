using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] GameObject music;
    [SerializeField] Text time;
    float timeb;

    void Start()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        music.gameObject.SetActive(true);
    }

    public void Update()
    {
        timeb += Time.deltaTime;
        time.text = timeb.ToString(); 
    }
}
