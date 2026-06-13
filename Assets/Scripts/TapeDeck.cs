using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TapeDeck : MonoBehaviour
{
    public AudioSource music;
    public Slider timeRemainingSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // set max value of slider to length of music
        timeRemainingSlider.maxValue = music.clip.length;
        
    }

    // Update is called once per frame
    void Update()
    {
        // move slider to current music position
        timeRemainingSlider.value = music.time;
    }
}
