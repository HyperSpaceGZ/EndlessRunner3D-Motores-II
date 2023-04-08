using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject SpawnedPrefab;

    //coords mid
    public float GroundXmid;
    public float GroundY;
    public float GroundZ;

    //coord right
    public float GroundXright;

    //coord left
    public float GroundXleft;

    //spawn time range
    public float SpawnTimeMin = 1f;
    public float SpawnTimeMax = 4f;


    private void Start()
    {
        StartCoroutine(ConeSpawnerMid(Random.Range(SpawnTimeMin, SpawnTimeMax), SpawnedPrefab));
        StartCoroutine(ConeSpawnerRight(Random.Range(SpawnTimeMin, SpawnTimeMax), SpawnedPrefab));
        StartCoroutine(ConeSpawnerLeft(Random.Range(SpawnTimeMin, SpawnTimeMax), SpawnedPrefab));

    }

    private IEnumerator ConeSpawnerMid(float randomtime, GameObject Obstacle)
    {
        yield return new WaitForSeconds(randomtime);
        Instantiate(Obstacle, new Vector3(GroundXmid, GroundY, GroundZ), Quaternion.identity);
        StartCoroutine(ConeSpawnerMid(randomtime, Obstacle));
    }

    private IEnumerator ConeSpawnerRight(float randomtime, GameObject Obstacle)
    {
        yield return new WaitForSeconds(randomtime);
        Instantiate(Obstacle, new Vector3(GroundXright, GroundY, GroundZ), Quaternion.identity);
        StartCoroutine(ConeSpawnerRight(randomtime, Obstacle));
    }

    private IEnumerator ConeSpawnerLeft(float randomtime, GameObject Obstacle)
    {
        yield return new WaitForSeconds(randomtime);
        Instantiate(Obstacle, new Vector3(GroundXleft, GroundY, GroundZ), Quaternion.identity);
        StartCoroutine(ConeSpawnerLeft(randomtime, Obstacle));
    }
}
