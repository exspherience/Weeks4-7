using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    // type of prefab will be GameObject
    public GameObject runnerPrefab;
    public GameObject existingRunner;
    public Vector3 spawnLocation;
    public float spawnSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            // Destroys gameObject
            // passing float adds delay of x seconds
            Destroy(existingRunner); //, 3f);
        }

        //if (Mouse.current.leftButton.wasPressedThisFrame)
        //{

        //}
    }

    public void OnSpawnPress()
    {
        spawnSpeed = Random.Range(1f, 6f);

        // Spawn Runner
        // Instatiate is method used to spawn items into scene
        // Has quirks
        // Needs Game Object but can also take 12 other alternatives (13 total)
        // These change how spawn things into object
        // This version only spawns object
        //Instantiate(runnerPrefab);

        // Spawn Runner as GameObject child of Object
        // lower case transform specifies that this should be child of Spawner
        //Instantiate(runnerPrefab, transform);

        // Vector3 zeroVector = Vector.zero sets all values to 0 in Position
        // Equivalent to New Quarternion(0,0,0,0)
        // Quaternion zeroRotation = Quaternion.identity;

        // Spawn Runner in Specific position
        GameObject spawnedObject = Instantiate(runnerPrefab, spawnLocation, Quaternion.identity);

        // Get Component gets component of object
        // assign to value
        SpriteRenderer spawnedSpriteRenderer = spawnedObject.GetComponent<SpriteRenderer>();

        // Best Practice: Check if component exists before using
        if (spawnedSpriteRenderer != null)
        {
            spawnedSpriteRenderer.color = Random.ColorHSV();
        }

        // can also be used on scripts applied to objects
        // this lets get variables from scripts
        Runner spawnedRunner = spawnedObject.GetComponent<Runner>();

        if (spawnedRunner != null)
        {
            spawnedRunner.speed = spawnSpeed;
        }

        // destroy object after x seconds
        Destroy(spawnedObject, 5f);
    }
}
