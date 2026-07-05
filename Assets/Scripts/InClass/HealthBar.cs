using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Image healthbarFillImage;

    public float currentHealth = 100f;
    public float maxHealth = 100f;

    public SpriteRenderer enemyRenderer;
    public AudioSource damageSound; // gets audio source 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        bool isMouseClicked = Mouse.current.leftButton.wasReleasedThisFrame;
        bool isMouseOverEnemy = enemyRenderer.bounds.Contains(mousePosition);

        bool shouldTakeDamage = isMouseOverEnemy && isMouseClicked;
        Debug.Log("Click[" + isMouseClicked + "] Over Enemy[" + isMouseOverEnemy + "]");
        if (shouldTakeDamage)
        {
            currentHealth -= 10f;
            damageSound.Play(); // plays audio

            if(currentHealth <= 0f)
            {
                enemyRenderer.gameObject.SetActive(false);
            }
            healthbarFillImage.fillAmount = currentHealth / maxHealth;
        }


    }
}
