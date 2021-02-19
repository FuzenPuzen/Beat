using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] PointDrag pointDrag;
    [SerializeField] GameObject particle;
    [SerializeField] bool invinsible;
    [SerializeField] GameObject music;
    [SerializeField] GameObject deathSound;


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

    public void Update()
    {
        if (transform.position.x >= 2.3f || transform.position.x <= -2.3f)
        {
            transform.position = Vector3.zero;
        }
        if (transform.position.y <= -5f)
        {
            transform.position = Vector3.zero;
        }
    }

    public IEnumerator Timer()
    {
        Destroy(music);
        deathSound.GetComponent<AudioSource>().Play();
        Handheld.Vibrate();
        transform.GetComponent<SpriteRenderer>().color = new Color(0,0,0,0);
        transform.GetComponent<CircleCollider2D>().enabled = false;
        Instantiate(particle, transform);
        Time.timeScale = 0.2f;
        pointDrag.canDrag = false;
        yield return new WaitForSeconds(0.4f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
