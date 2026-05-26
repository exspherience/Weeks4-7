using UnityEngine;

public class Clock : MonoBehaviour
{
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // euler angles for rotation
        // transform.rotation is quaterion
        Vector3 currentRotation = transform.eulerAngles;

        // transform shows values from -180 to 180
        // but eular angles goes from 0 to 360!
        // do not trust the inspector!!
        currentRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = currentRotation;
    }
}
