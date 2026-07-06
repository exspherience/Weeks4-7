using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Digital Clock font by PixelMoondust: https://www.dafont.com/digital-clock-2.font
public class TimeMachineController : MonoBehaviour
{
    public TextMeshProUGUI yearText;
    public Slider yearSlider;
    public GameObject timeMachineCore;
    public GameObject lightBeam;

    public bool timeTravelStart;
    public float duration = 3f;
    public float speed;
    public float currentYear = 2010;
    float beamProgress = 0f;

    public Vector3 startValue;
    public Vector3 endValue;

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

        if(timeTravelStart)
        {
            beamProgress += Time.deltaTime;
            animateBeam();
        }
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

    public void startTimeTravel()
    {
        timeTravelStart = true;
    }

    void animateBeam()
    {
        // Lerp the beam scale so it grows
        lightBeam.transform.localScale = Vector3.Lerp(startValue, endValue, beamProgress/duration);

        // if the beam has grown to full size, swap the start and end so it shrinks down
        if (beamProgress >= duration && lightBeam.transform.localScale.x != 0f)
        {
            setBeamSize(startValue, endValue);
            beamProgress = 0f;
        }
        // if the beam hits width hits zero again, swap start and end so it can grow next time the button is pressed
        // return timeTravelStart to false so that the animation can play again next button press
        if(lightBeam.transform.localScale.x == 0f && beamProgress >= duration)
        {
            setBeamSize(startValue, endValue);
            beamProgress = 0f;
            timeTravelStart = false;
        }
    }

    // swap the start and end sizes of the beam when called
    void setBeamSize(Vector3 startSize, Vector3 endSize)
    {
        Vector3 tempValue = endValue;
        endValue = startValue;
        startValue = tempValue;
    }
}
