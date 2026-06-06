using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class DescribeImage : MonoBehaviour
{
    public TextMeshProUGUI imageDescription;
    float distanceThreshold = 1f;
    public bool isBurger;
    public bool isPizza;
    public bool isIceCream;
    public bool isSecret;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (Vector2.Distance(transform.position, mousePos) < distanceThreshold)
        {
            if (isBurger)
            {
                imageDescription.text = "This is a hamburger.";
            }
            else if (isPizza)
            {
                imageDescription.text = "This is a slice of pizza.";
            }
            else if (isIceCream)
            {
                imageDescription.text = "This is an ice cream cone.";
            }
            else if (isSecret)
            {
                imageDescription.text = "Whose eyes are those eyes?";
            }
        }
    }

}
