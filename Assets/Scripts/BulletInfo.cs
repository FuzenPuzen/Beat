using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInfo : MonoBehaviour
{
    float bulletSpeed;
    void Start()
    {
        
    }

    public void SetSpeed(float _bulletSpeed)
    {
        bulletSpeed = _bulletSpeed;
    }
    
    void Update()
    {
        transform.position += transform.right * bulletSpeed * Time.deltaTime;
    }
}
