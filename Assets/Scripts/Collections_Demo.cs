using System.Collections.Generic;
using UnityEngine;

public class Collections_Demo : MonoBehaviour
{
    public List<string> animals;
    // when public list has initial value
    // if private, initial value must be set
    public SpriteRenderer mySprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Simple Types
        //int number = 1;
        //float decimalNumber = 1.5f;
        //string word = "cow";

        // Structs
        // more complicated data type
        // similar to classes
        // store simple types within  (classes can contain more complicated data)
        // needs Constructor!
        // examples
        //Vector3 vectorExample = new Vector3(3, 3, 3); // 3 floats
        //Vector2 vector2Example = new Vector2(2, 2); // 2 floats
        Color greyColor = new Color(0.3f,0.3f,0.3f,1f); // 3-4 floats
        mySprite.color = greyColor;
        // Classes
        // more complicated data
        // could contain List, another class
        // can only make MonoBehavior as Class

        // List constructor
        animals = new List<string>(); 

        animals.Add("Raccoon");
        animals.Remove("Dog");

        for(int i = 0; i < animals.Count; i++)
        {
            Debug.Log(animals[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
