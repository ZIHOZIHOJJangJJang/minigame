using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour
{
    float speed = 10;

    Transform bulletTrans;
    Vector3 dir;
    GameObject lastDir;

    public void Direction(Vector3 direction)
    {
        dir = direction;
    }

    private void Awake()
    {
        bulletTrans = GetComponent<Transform>();
        Destroy(gameObject, 1.5f);
    }

    void Update()
    {
        bulletTrans.position += dir * speed * Time.deltaTime;
    }
}
