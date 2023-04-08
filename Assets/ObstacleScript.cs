using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float ObstacleSpawnedTime = 0f;
    public float ObstacleDespawnTime = 3f;
    public float ObstacleSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, ObstacleSpeed * (Time.deltaTime));
        ObstacleSpawnedTime += Time.deltaTime;
        if (ObstacleSpawnedTime >= ObstacleDespawnTime)
        {
            Destroy(this.gameObject);
        }

    }
}
