using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Digital Clock font by PixelMoondust: https://www.dafont.com/digital-clock-2.font
public class TimeMachineController : MonoBehaviour
{
    public TextMeshProUGUI yearText;
    public Slider yearSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setYearText();
    }

    void setYearText()
    {
        yearText.text = "TARGET: " + yearSlider.value;
    }
}
