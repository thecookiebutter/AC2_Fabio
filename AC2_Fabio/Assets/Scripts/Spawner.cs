using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public float spawnInterval = 1.0f;
    public Vector2 sizeRange = new Vector2(0.5f, 3.0f);
    private BoxCollider2D spawnArea;
    void Start()
    {
        spawnArea = GetComponent<BoxCollider2D>();
        InvokeRepeating("SpawnMeteor", 0f, spawnInterval);
    }

private void SpawnMeteor()
    {

        Vector3 spawnPosition = new Vector3(
            Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x),
            spawnArea.transform.position.y,
            Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z)
        );

        GameObject meteor = Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
	spawnInterval = Random.Range(0.5f, 5.0f);

        float randomSize = Random.Range(sizeRange.x, sizeRange.y);
        meteor.transform.localScale = new Vector3(randomSize, randomSize, randomSize);
    }
    
}
