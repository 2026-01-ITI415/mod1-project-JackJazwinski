using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject hazardPrefab;
    public float spawnRange = 8f;
    public float spawnHeight = 10f;
    public float spawnDelay = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnHazard", 1f, spawnDelay);
    }

    void SpawnHazard()
    {
        float randomX = Random.Range(-spawnRange, spawnRange);
        float randomZ = Random.Range(-spawnRange, spawnRange);

        Vector3 spawnPos = new Vector3(randomX, spawnHeight, randomZ);

        Instantiate(hazardPrefab, spawnPos, Quaternion.identity);
    }
}