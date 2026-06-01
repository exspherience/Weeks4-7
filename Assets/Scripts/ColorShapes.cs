using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorShapes : MonoBehaviour
{
    //public SpriteRenderer coloredSprite;
    public List<SpriteRenderer> shapes;
    int index = 0;
    float progress;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changeShape();
        changeColor();
    }

    void changeColor()
    {
        progress += Time.deltaTime;

        // change color of shape at index every second
        if (progress >= 1)
        {   
            shapes[index].color = UnityEngine.Random.ColorHSV();
            progress = 0f;
        }
    }

    void changeShape()
    {
        // increase index if any key pressed
        if(Keyboard.current.anyKey.wasPressedThisFrame)
        {
            index++;

            // reset index 
            if(index >= shapes.Count)
            {
                index = 0;
            }
        }

    }
}
