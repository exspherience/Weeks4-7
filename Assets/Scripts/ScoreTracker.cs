using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    //public Slider scoreSlider;
    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    public void updateSliderScore(float scoreValue)
    {
        //scoreText.text = "Score: " + scoreSlider.value;
        scoreText.text = "Score: " + scoreValue;
    }
}
