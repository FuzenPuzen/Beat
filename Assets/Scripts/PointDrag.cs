using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PointDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler
{
    [SerializeField] GameObject touch;
    [SerializeField] Vector3 Offset;
    public bool canDrag;

    // Start is called before the first frame update
    void Start()
    {
        canDrag = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (canDrag)
        { 
            Vector3 buff = Camera.main.ScreenToWorldPoint(eventData.position) + new Vector3(0, 0, 10);
            touch.transform.position = buff + Offset;
        }  
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (canDrag)
        {
            Vector3 buff = Camera.main.ScreenToWorldPoint(eventData.position) + new Vector3(0, 0, 10);
            touch.transform.position = buff + Offset;
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
