using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Digital Clock font by PixelMoondust: https://www.dafont.com/digital-clock-2.font
public class TimeMachineController : MonoBehaviour
{
    public TextMeshProUGUI yearText;
    public Slider yearSlider;
    public GameObject timeMachineCore;
    public float speed;
    public float currentYear = 2010;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set speed based on distance of slider value from set current year
        speed = currentYear - yearSlider.value;
        setYearText();
        rotateCore();
    }

    // Sets text for Year Display based on what value of slide is
    void setYearText()
    {
        yearText.text = "TARGET: " + yearSlider.value;
    }

    // Rotates the gear that is in the center of the time machine sprite
    void rotateCore()
    {
        Vector3 currentRotation = timeMachineCore.transform.eulerAngles;
        currentRotation.z += speed * Time.deltaTime;
        timeMachineCore.transform.eulerAngles = currentRotation;
    }

    // Sets currentYear to value from slider
    // Called when Time Travel button is Clicked
    public void setCurrentYear()
    {
        currentYear = yearSlider.value;
    }
}
