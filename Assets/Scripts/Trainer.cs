using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Script for Porkemon Trainer
public class Trainer : MonoBehaviour
{
    // For Porkachu
    public SpriteRenderer creatureRenderer;
    //public Camera gameCamera;
    public Color caughtColor;

    // Lists
    public List<SpriteRenderer> uncaughtCreatures;
    public List<SpriteRenderer> caughtCreatures;

    public Hider creatureHider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        bool isClicked = Mouse.current.leftButton.wasPressedThisFrame;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        // Vector3 worldMousePos = gameCamera.ScreenToWorldPoint(mousePosition);
        // worldMousePos.z = 0f;

        if(isClicked)
        {
            // for each item in caughtCreatures, write all to console
            for (int i = 0; i < caughtCreatures.Count; i++)
            {
                Debug.Log(caughtCreatures[i]);
            }
            
            //foreach(SpriteRenderer i in caughtCreatures)
            //{
            //    Debug.Log(i);
            //}
        }

        // bounds is maximum horizontal, vertical space that shape exists within screen
        // will be square around object so not exact on sprite
        if(isClicked && creatureRenderer.bounds.Contains(mousePos))
        {
            creatureRenderer.color = caughtColor;

            // checks to see if List does not contain variable
            // .Contains(argument) checks if item is in list
            if (!caughtCreatures.Contains(creatureRenderer))
            {
                creatureHider.Hide();
                caughtCreatures.Add(creatureRenderer); // adds object to list
                //Debug.Log("Caught creature!");
            }

            uncaughtCreatures.Remove(creatureRenderer); // removes object from list
        }
    }
}
