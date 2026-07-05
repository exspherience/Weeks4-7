using UnityEngine;

public class Runner : MonoBehaviour
{
    public float speed;
    bool isMoving = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    public void OnMoveClick()
    {
        isMoving = true;
    }

    public void OnStopClick()
    {
        isMoving = false;
    }

    public void OnFlipClick()
    {
        speed = -speed;
    }
}
