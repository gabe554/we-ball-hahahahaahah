using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnernumbertwo : MonoBehaviour
{
    public GameObject Enemy
       ;
    public float spawnRate = 2;
    private float timer = 0;
    public float widthOffset = 4;
    // Start is called before the first frame update
    void Start()
    {
        float lowestPoint2 = transform.position.x - widthOffset;
        float highestPoint2 = transform.position.x + widthOffset;

        Instantiate(Enemy, new Vector3(Random.Range(lowestPoint2, highestPoint2), transform.position.y, 0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnEnemy();
            timer = 0;
        }

    }

    void spawnEnemy()
    {
        float lowestPoint2 = transform.position.x - widthOffset;
        float highestPoint2 = transform.position.x + widthOffset;

        Instantiate(Enemy, new Vector3(Random.Range(lowestPoint2, highestPoint2), transform.position.y , 0), transform.rotation);
    }
}
