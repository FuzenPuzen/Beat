using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField] List<GameObject> equalizers;

    [System.Serializable]
    public class ElementNonSpawn
    {
        public float time;
        public GameObject obj;
    }

    [System.Serializable]
    public class Element
    {
        public float time;
        public GameObject obj;
        public Transform coord;
    }
    public List<Element> elements = new List<Element>();
    public List<ElementNonSpawn> elements2 = new List<ElementNonSpawn>();

    public void Start()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            StartCoroutine(Wait(elements[i]));
        }

        for (int i = 0; i < elements2.Count; i++)
        {
            StartCoroutine(WaitEqua(elements2[i]));
        }
        StartCoroutine(Waited(22.6f));
        StartCoroutine(Waited(24.6f));
    }
    
    private IEnumerator Wait(Element _element)
    {
        yield return new WaitForSeconds(_element.time);
        Instantiate(_element.obj, _element.coord.position, _element.obj.transform.rotation);
    }

    private IEnumerator WaitEqua(ElementNonSpawn _element2)
    {
        yield return new WaitForSeconds(_element2.time);
        _element2.obj.GetComponent<Equlizer>().MultiReplay();
    }

    private IEnumerator Waited(float _time)
    {
        yield return new WaitForSeconds(_time);
        Handheld.Vibrate();
    }

}
