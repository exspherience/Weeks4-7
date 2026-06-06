using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
    }
}
