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
    [SerializeField] ParticleSystem trail;
    public bool canPause;
    


    void Start()
    {
        canPause = true;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            OnDeath();
        }
    }

    public void OnDeath()
    {
        if (!invinsible)
        {
            StartCoroutine(Timer());
            canPause = false;
            pointDrag.pauseBack.SetActive(false);
        }
    }


    public void Update()
    {
        if (transform.position.x >= 2.6f || transform.position.x <= -2.6f)
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
        music.GetComponent<AudioSource>().volume = 0;
        var emit = trail.emission;
        emit.rateOverTimeMultiplier = 0;      
        deathSound.GetComponent<AudioSource>().Play();
        Handheld.Vibrate();
        transform.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        transform.GetComponent<PolygonCollider2D>().enabled = false;
        Instantiate(particle, transform);
        Time.timeScale = 0.2f;
        pointDrag.canDrag = false;
        yield return new WaitForSeconds(0.4f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
