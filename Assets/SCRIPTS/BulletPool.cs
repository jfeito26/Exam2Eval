using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int poolSize = 15;
    private List<GameObject> bullets;

    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
        for(int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.SetActive(false);
            bullets.Add(obj);
        }

    }

    public GameObject GetBullet()
    {
        foreach(GameObject b in bullets)
        {
            if(!b.activeInHierarchy)
            {
                b.SetActive(true);
                return b;
            }
        }
        GameObject first = bullets[0];
        first.SetActive(false);
        first.SetActive(true);
        return first;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
