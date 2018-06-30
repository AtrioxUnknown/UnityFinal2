using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD_Manager : MonoBehaviour {

    public int StartingHealth;
    int CurrentHealth;
    public Slider health_bar;

    // Use this for initialization
    void Start() {
        CurrentHealth = StartingHealth;
        health_bar.value = CurrentHealth;
    }

    public void UpdateHealth(int amount)
    {
        CurrentHealth = CurrentHealth + amount;
        health_bar.value = CurrentHealth;
        if (CurrentHealth <= 0)
        {
            Death();
        }



    }

    void Death()
    {
        SceneManager.LoadScene("blerg level 1");
    }
}