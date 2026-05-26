using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    // type of prefab will be GameObject
    public GameObject runnerPrefab;
    public Vector3 spawnLocation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // Spawn Runner
            // Instatiate is method used to spawn items into scene
            // Has quirks
            // Needs Game Object but can also take 12 other alternatives (13 total)
            // These change how spawn things into object
            // This version only spawns object
            Instantiate(runnerPrefab);

            // Spawn Runner as GameObject child of Object
            // lower case transform specifies that this should be child of Spawner
            Instantiate(runnerPrefab, transform);

            // Vector3 zeroVector = Vector.zero sets all values to 0 in Position
            // Equivalent to New Quarternion(0,0,0,0)
            // Quaternion zeroRotation = Quaternion.identity;

            // Spawn Runner in Specific position
            Instantiate(runnerPrefab, spawnLocation, Quaternion.identity);
        }
    }
}
