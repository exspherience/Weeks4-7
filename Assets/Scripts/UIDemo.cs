using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIDemo : MonoBehaviour
{
    public SpriteRenderer sr;
    public TextMeshProUGUI score;
    public TextMeshProUGUI sliderDisplay;
    public Image duckieImage;
    public Slider slider;
    float howManyClicks;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        score.text = howManyClicks.ToString();

        // slider can set minValue or maxValue
            // slider.minValue = 0;
            // slider.maxValue = 10;
        // can toggle whole numbers from code
            // slider.wholeNumbers = true;
 
    }

    // Update is called once per frame
    void Update()
    {
        sliderDisplay.text = slider.value.ToString();

        if(Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            ChangeColor();
        }
    }

    public void ChangeColor()
    {
        sr.color = Random.ColorHSV();
        duckieImage.color = sr.color;
    }

    public void SetScaleBig(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }

    public void AddToTheNumber()
    {
        howManyClicks++;
        score.text = howManyClicks.ToString();
    }
}
