using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 3;

    public Image[] hearts;

    public Sprite fullHearts;
    public Sprite emptyHearts;

    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHeartsUI();
    }

   public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        UpdateHeartsUI();

        if (currentHealth <= 0) 
        {
            GameOver();
        }
    }


    void UpdateHeartsUI()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].sprite = (i < currentHealth) ? fullHearts : emptyHearts;

        }
    }

    void GameOver()
    {

    }
}
