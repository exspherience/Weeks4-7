using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
        yearText.text = yearSlider.value.ToString();
    }
}
