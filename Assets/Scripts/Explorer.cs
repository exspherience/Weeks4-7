using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Explorer : MonoBehaviour
{
    public float health;
    public float speed;
    public float freezeTimer;
    public float unfreezeTimer;
    public float duration;
    public SpriteRenderer explorerRenderer;
    bool frozen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        explorerRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (frozen)
        {
            freezeTimer += Time.deltaTime;
            Unfreeze();
        }
        Vector3 directionToMove = Vector3.zero;

        //Or use constructor:
        //directionToMove = new Vector3(0,0,0);

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            directionToMove.x -= 1f;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            directionToMove.x += 1f;
        }

        if (Keyboard.current.upArrowKey.isPressed)
        {
            directionToMove.y += 1f;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            directionToMove.y -= 1f;
        }

        transform.position += directionToMove * speed * Time.deltaTime;
    }
    public void TakeDamage()
    {
        health -= 10;
    }

    public void SlowDown()
    {
        speed -= 1.5f;
    }

    public void SpeedUp()
    {
        speed += 1.5f;
    }

    public void Freeze()
    {
        if (freezeTimer < duration)
        {
            explorerRenderer.color = Color.cyan;
            speed = 0f;
            frozen = true;
        }
    }

    public void Unfreeze()
    {
        if (freezeTimer >= duration)
        {
            explorerRenderer.color = Color.white;
            frozen = false;
            speed = 2f;
        }
    }
    public void ResetTimer()
    {
        freezeTimer = 0f;
    }
}

