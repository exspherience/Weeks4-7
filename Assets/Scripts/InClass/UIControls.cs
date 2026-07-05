using UnityEngine;
using UnityEngine.UI;

public class UIControls : MonoBehaviour
{
    public Slider rotationSlider;
    public float maxRotation = 360f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotationSlider.maxValue = maxRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // change color of Sprite
    // takes SpriteRenderer as argument, can be set on Button Click
    public void changeColor(SpriteRenderer spriteToChange)
    {
        // set to random color
        spriteToChange.color = Random.ColorHSV();
    }

    public void rotateShape()
    {
        Vector3 rotationValue = new Vector3(0,0,rotationSlider.value);
        transform.eulerAngles = rotationValue;
    }
}
