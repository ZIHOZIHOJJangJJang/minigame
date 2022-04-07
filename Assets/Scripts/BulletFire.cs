using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    float x;

    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    GameObject bulletFire;
    GameObject bullet;
    Vector3 lastDir = Vector3.right;

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");

        bulletFire.transform.position = transform.position;

        
        if (x != 0)
        {
            lastDir = new Vector3(x, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            bullet = Instantiate(bulletPrefab);
            bullet.transform.position = bulletFire.transform.position;
            bullet.GetComponent<BulletLife>().Direction(lastDir);
        }
    }
}
