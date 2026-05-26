using UnityEngine;

public class Hider : MonoBehaviour
{
    public Vector3 hidePosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hide()
    {
        transform.position = hidePosition;
    }
}
