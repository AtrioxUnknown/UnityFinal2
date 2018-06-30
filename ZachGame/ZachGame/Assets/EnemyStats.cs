using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public GameManager gamemanager;    
    public Material[] Materials;
    public GameObject[] Spawns;
    public int StartingHealth;
    int CurrentHealth;

    // Use this for initialization
    void Start()
    {
        CurrentHealth = StartingHealth;
    }

    public void UpdateHealth(int amount)
    {
        CurrentHealth = CurrentHealth + amount;
        if (CurrentHealth <= 0)
        {

            Death();
        }
    }
    void Death()
    {
        gamemanager.DragonCount++;
        GetComponentInChildren<Renderer>().material = Materials[gamemanager.DragonCount];
        transform.position = Spawns[gamemanager.DragonCount].transform.position;
        CurrentHealth = StartingHealth;
    }
}
