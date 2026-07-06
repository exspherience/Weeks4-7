using System.Security.Cryptography;
using UnityEngine;

public class SparkBehavior : MonoBehaviour
{
    public float timer = 0f;
    public float duration = 6f;
    public AnimationCurve sparkCurve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // set duration to random amount of time so each spark animates at slightly different speed
        duration = Random.Range(3f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        // animates sparks in pulsing motion
        timer += Time.deltaTime;
        transform.localScale = sparkCurve.Evaluate(timer / duration) * Vector3.one;

        // restarts timer so animation continues
        if (timer >= duration) timer = 0f;
    }


}
