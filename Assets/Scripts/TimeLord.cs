using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLord : MonoBehaviour
{
    public void ShangeTimeSpeed(float _timeSpeed)
    {
        Time.timeScale = _timeSpeed;
    }
}
