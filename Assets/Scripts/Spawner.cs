using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject hazardPrefab;
    public GameObject warningPrefab;
    public float spawnRange = 8f;
    public float spawnHeight = 10f;
    public float spawnDelay = 2f;

    void Start()
    {
        InvokeRepeating("SpawnWarning", 1f, spawnDelay);
    }

    void SpawnWarning()
    {
        float randomX = Random.Range(-spawnRange, spawnRange);
        float randomZ = Random.Range(-spawnRange, spawnRange);
        Vector3 groundPos = new Vector3(randomX, 0.05f, randomZ);
        GameObject marker = Instantiate(warningPrefab, groundPos, Quaternion.identity);
        StartCoroutine(DropHazard(marker));
    }
    IEnumerator DropHazard(GameObject marker)
    {
        yield return new WaitForSeconds(1f);
        Vector3 spawnPos = new Vector3(marker.transform.position.x, spawnHeight, marker.transform.position.z);
        GameObject hazard = Instantiate(hazardPrefab, spawnPos, Quaternion.identity);
        hazard.GetComponent<Hazard>().warningMarker = marker;
    }
}