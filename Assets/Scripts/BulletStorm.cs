using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStorm : MonoBehaviour
{
    [SerializeField] float bulletScale;
    [Range (1, 10)]
    [SerializeField] float bulletSpeed;
    [SerializeField] int bulletCount;
    [SerializeField] GameObject BulletPb;
    GameObject bulletObj;
    float spawnAngle;

    void Start()
    {
        spawnAngle = 360f / bulletCount;
        SpawnBullet();
    }

    public void SpawnBullet()
    {
        for (int i = 0; i < bulletCount; i++)
        {
            bulletObj = Instantiate(BulletPb, transform);
            bulletObj.transform.localScale = new Vector3(bulletScale, bulletScale, bulletScale);
            bulletObj.GetComponent<BulletInfo>().SetSpeed(bulletSpeed);
            bulletObj.transform.Rotate(new Vector3(0,0,spawnAngle * i));
        }
    }
}
