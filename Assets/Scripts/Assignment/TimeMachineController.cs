using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Digital Clock font by PixelMoondust: https://www.dafont.com/digital-clock-2.font
public class TimeMachineController : MonoBehaviour
{
    public TextMeshProUGUI yearText;
    public Slider yearSlider;
    public Button timeTravelButton;
    public GameObject timeMachineCore;
    public GameObject lightBeam;

    public bool timeTravelStart;
    public float beamDuration = 3f;
    public float machineDuration = 6f;
    public float speed;
    public float currentYear = 2010;

    public Vector3 beamStartValue;
    public Vector3 beamEndValue;
    float beamProgress = 0f;

    public Vector3 machineStartValue;
    public Vector3 machineEndValue;
    float machineProgress = 0f;

    public float cooldownTimer = 0f;
    public float cooldownDuration = 2f;
    public bool machineVisible = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ensure machineEndValue is 0 at start
        machineEndValue = Vector3.zero; 
    }

    // Update is called once per frame
    void Update()
    {
        // set speed based on distance of slider value from set current year
        speed = currentYear - yearSlider.value;
        SetYearText();
        RotateCore();
        ToggleControls();

        if(timeTravelStart)
        {
            TimeTravel();
        }

        // waits for cooldown to end before time machine appears again
        if(!machineVisible)
        {
            cooldownTimer += Time.deltaTime;
            if(cooldownTimer >= cooldownDuration)
            {
                StartTimeTravel();
                cooldownTimer = 0f;
            }
        }
    }

    // Sets text for Year Display based on what value of slide is
    void SetYearText()
    {
        yearText.text = "TARGET: " + yearSlider.value;
    }

    // Rotates the gear that is in the center of the time machine sprite
    void RotateCore()
    {
        Vector3 currentRotation = timeMachineCore.transform.eulerAngles;
        currentRotation.z += speed * Time.deltaTime;
        timeMachineCore.transform.eulerAngles = currentRotation;
    }

    // Sets currentYear to value from slider
    // Called when Time Travel button is Clicked
    public void SetCurrentYear()
    {
        currentYear = yearSlider.value;
    }

    public void StartTimeTravel()
    {
        timeTravelStart = true;
    }

    public void TimeTravel()
    {
        // start beam and machine timers
        // begin animations
        beamProgress += Time.deltaTime;
        machineProgress += Time.deltaTime;
        AnimateBeam();
        AnimateTimeMachine();
    }

    // toggle interactivity of controls depending on animation state
    void ToggleControls()
    {
        // ensure time machine controls on if nothing is animating
        if (machineVisible && !timeTravelStart)
        {
            timeTravelButton.interactable = true;
            yearSlider.interactable = true;

            // disable button if slider is on current year
            if (yearSlider.value == currentYear)
            {
                timeTravelButton.interactable = false;
            }
        }
        // disable button and slider while animations are playing
        else
        {
            timeTravelButton.interactable = false;
            yearSlider.interactable = false;
        }
    }

    /////////////////////////
    /// Animation Methods ///
    /////////////////////////
    void AnimateBeam()
    {
        // Lerp the beam scale so it grows
        lightBeam.transform.localScale = Vector3.Lerp(beamStartValue, beamEndValue, beamProgress/beamDuration);

        // if the beam has grown to full size, swap the start and end so it shrinks down
        if (beamProgress >= beamDuration)
        {
            SwapBeamValues();
            beamProgress = 0f;
            // marks timeTravelState as ended if beam size is 0
            if (lightBeam.transform.localScale.x == 0f)
            {
                timeTravelStart = false;
            }
        }
    }

    void AnimateTimeMachine()
    {
        // shrinks or grows time machine object
        transform.localScale = Vector3.Lerp(machineStartValue, machineEndValue, machineProgress / machineDuration);

        // if machineProgress has exceeded duration, swap start and end values so lerp will do opposite next time called
        // reset progress timer
        if (machineProgress > machineDuration)
        {
            SwapMachineValues();
            machineProgress = 0f;
        }
        // mark machine as not visible when scale is at 0 so cool down can begin in Update
        if (transform.localScale.x == 0f)
        {
            machineVisible = false;
        }
        else machineVisible = true; 
    }

    // swap the start and end sizes of the beam when called
    void SwapBeamValues()
    {
        Vector3 tempBeamValue = beamEndValue;
        beamEndValue = beamStartValue;
        beamStartValue = tempBeamValue;
    }

    // swap machine start and end values 
    void SwapMachineValues()
    {
        Vector3 tempValue = machineEndValue;
        machineEndValue = machineStartValue;
        machineStartValue = tempValue;
    }
}
