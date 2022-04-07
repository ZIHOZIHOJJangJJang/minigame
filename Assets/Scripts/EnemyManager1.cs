using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager1 : MonoBehaviour
{
    float random;
    float randomPosition;
    float minTime = 0;
    float maxTime = 4;
    [SerializeField]
    GameObject enemyFactory;
    

    void Update()
    {
        randomPosition = Random.Range(-4.5f, 4.5f);
        random = Random.Range(minTime, maxTime);
        minTime += Time.deltaTime;
        if (minTime >= random)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position + new Vector3(0, randomPosition, 0);
            minTime = 0;
        }
    }
}
