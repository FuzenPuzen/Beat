using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PointDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 Offset;
    public bool canDrag;
    Vector3 prevPos;

    // Start is called before the first frame update
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
            // Vector3 buff = Camera.main.ScreenToWorldPoint(eventData.position);
            //touch.transform.position = buff + Offset;
            prevPos = Camera.main.ScreenToWorldPoint(eventData.position);
            prevPos = new Vector3(prevPos.x, prevPos.y, 0);
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //touch.GetComponent<TrailRenderer>().enabled = false;
        //touch.GetComponent<TrailRenderer>().enabled = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }
}
