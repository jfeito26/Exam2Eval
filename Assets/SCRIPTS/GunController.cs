using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public BulletPool bulletPool;
    public float bulletSpeed = 20f;
    public Transform firepoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Shoot();
        }
        //else if (Unity_android)
        //{
        //    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) ;
        //}
    }

    void Shoot()
    {
        GameObject bullet = bulletPool.GetBullet();
        bullet.transform.position = firepoint.position;
        bullet.transform.rotation = firepoint.rotation;
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = bullet.transform.forward * bulletSpeed;
    }
}
