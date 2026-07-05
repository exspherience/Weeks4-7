using UnityEngine;

public class Clock : MonoBehaviour
{
    public float speed;
    public bool isHour;
    public AudioSource clockChime;
    public SpriteRenderer cuckoo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // euler angles for rotation
        // transform.rotation is quaterion
        Vector3 currentRotation = transform.eulerAngles;

        // transform shows values from -180 to 180
        // but eular angles goes from 0 to 360!
        // do not trust the inspector!!
        currentRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = currentRotation;

        // checks if z angle of rotation divisible by 30
        // cast to integer so decimals are ignored
        // checks if object has isHour set to true
        // checks if chime isn't already playing to prevent overlap
        if ((int)transform.eulerAngles.z % 30 == 0 && isHour && !clockChime.isPlaying)
        {
            // plays audio and display the bird
            playChime();
            showBird();
        }

        if(!clockChime.isPlaying)
        {
            hideBird();
        }
    }

    void playChime()
    {
        clockChime.Play();//OneShot(clockChime.clip);
    }

    void showBird()
    {
        cuckoo.enabled = true;
    }

    void hideBird()
    {
        cuckoo.enabled = false;
    }
}
