using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 5f;
    float x;
    float y;
    Vector3 dir;
    Transform playerTrans;

    private void Awake()
    {
        playerTrans = GetComponent<Transform>();
    }

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        dir = new Vector3(x, y, 0);
        playerTrans.position += dir.normalized * speed * Time.deltaTime;
    }
}
