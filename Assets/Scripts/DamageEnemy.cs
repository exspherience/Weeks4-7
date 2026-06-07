
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class DamageEnemy : MonoBehaviour
{
    public SpriteRenderer enemyRenderer;
    public int enemyHealth;
    public TextMeshProUGUI enemyHealthDisplay;
    //public GameObject existingEnemy;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackEnemy();
        enemyHealthDisplay.text = enemyHealth.ToString();
    }

    void attackEnemy()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (enemyRenderer.bounds.Contains(mousePos) && Mouse.current.leftButton.wasPressedThisFrame)
        {
            enemyHealth--;
        }
    }


}
