using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public TextMeshProUGUI victoryMessage;
    public List<GameObject> enemies;
    public GameObject enemyPrefab;
    public Vector2 spawnLocation;
    GameObject spawnedEnemy;
    public int desiredEnemyAmount = 4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // generate 5 enemies, each in a random location
        // adds them to a list
        for (int j = 0; j <= desiredEnemyAmount; j++)
        {
            spawnedEnemy = Instantiate(enemyPrefab, randomLocation(), Quaternion.identity);
            enemies.Add(spawnedEnemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // checks enemy health
        // destroys enemy and removes from list if HP hits 0
        for (int i = 0; i < enemies.Count; i++)
        {
            DamageEnemy enemyHP = enemies[i].GetComponent<DamageEnemy>();
            if (enemyHP.enemyHealth <= 0)
            {
                Destroy(enemies[i]);
                enemies.Remove(enemies[i]);
            }
        }

        // check if enemy list is empty
        // if empty, all enemies defeated
        // displays victory message on screen
        if (enemies.Count == 0)
        {
            victoryMessage.text = "You Win!";
        }
    }

    // returns spawnLocation with random values
    Vector2 randomLocation()
    {
        return spawnLocation = new Vector2(Random.Range(-5, 5), Random.Range(-3, 3)); 
    }
}
