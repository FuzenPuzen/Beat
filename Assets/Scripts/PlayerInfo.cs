using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] PointDrag pointDrag;
    [SerializeField] GameObject particle;
    [SerializeField] bool invinsible;


    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            if(!invinsible)
            StartCoroutine(Timer());         
            //transform.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }


    public IEnumerator Timer()
    {
        transform.GetComponent<SpriteRenderer>().color = new Color(0,0,0,0);
        Instantiate(particle, transform);
        Time.timeScale = 0.2f;
        pointDrag.canDrag = false;
        yield return new WaitForSeconds(0.4f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
