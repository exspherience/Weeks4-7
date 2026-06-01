using UnityEngine;
using UnityEngine.InputSystem;

public class TankMovement : MonoBehaviour
{
    // speed for tank
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // screen position to check bounds
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        // if tank is not beyond right side of screen
        // pressing right moves tank right
        if (screenPos.x <= Screen.width && Keyboard.current.rightArrowKey.isPressed)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        // if tank is not beyond left side of screen
        // pressing left moves tank left
        if (screenPos.x >= 0 && Keyboard.current.leftArrowKey.isPressed)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

    }
}
