using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PointDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject music;
    [SerializeField] AudioSource pauseMusic;
    public bool canDrag;
    Vector3 prevPos;


    void Start()
    {
        canDrag = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (canDrag)
        {  
            Vector3 nowPos = Camera.main.ScreenToWorldPoint(eventData.position);
            nowPos = new Vector3(nowPos.x, nowPos.y, 0);
            Vector3 buff = prevPos - nowPos;
            player.transform.position -= buff;
            prevPos = Camera.main.ScreenToWorldPoint(eventData.position);
            prevPos = new Vector3(prevPos.x, prevPos.y, 0);
        }  
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (canDrag)
        {
            pauseMusic.volume = 0;
            music.GetComponent<AudioSource>().pitch = 1f;
            music.GetComponent<AudioSource>().volume = 1;
            Time.timeScale = 1f;
            prevPos = Camera.main.ScreenToWorldPoint(eventData.position);
            prevPos = new Vector3(prevPos.x, prevPos.y, 0);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        music.GetComponent<AudioSource>().pitch = 0.1f;
        music.GetComponent<AudioSource>().volume = 0;
        pauseMusic.volume = 1;
        pauseMusic.Play();
        Time.timeScale = 0.1f;

    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }
}
