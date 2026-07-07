using UnityEngine;

public class SparkSpawner : MonoBehaviour
{
    public GameObject sparkPrefab;
    public int sparkAmount = 5;
    public Vector3 spawnLocation;
    public float sparkDuration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // spawns amount of sparks specified at set location
    public void SpawnSparks()
    {
        for (int i = 0; i <= sparkAmount; i++)
        {
            SetSpawnLocation();
            GameObject spawnedObject = Instantiate(sparkPrefab, spawnLocation, Quaternion.identity);
            DestroySparks(spawnedObject);
        }
    }

    // destroys object that was 
    void DestroySparks(GameObject objectToDestroy)
    {
        Destroy(objectToDestroy, sparkDuration);
    }

    // spawns sparks in a random location near the time machine
    void SetSpawnLocation()
    {
        spawnLocation = new Vector3(Random.Range(-2f, 2f), Random.Range(-1f, 5f), 0);
    }
}
