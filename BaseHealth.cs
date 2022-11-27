using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BaseHealth : MonoBehaviour
{
    private float baseHealth = 5;
    float health;

    int numberOfHearts = 5;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    int damage = 1;
    void Start()
    {
        int difficultylvl = (int)PlayerPrefsController.GetDifficulty();
        if (difficultylvl == 0)
	    {
            health = baseHealth;
	    }
        if (difficultylvl == 1)
        {
            health = baseHealth - 2;
        }
        if (difficultylvl == 2)
        {
            health = baseHealth - 4;
        }
        Debug.Log("difficulty wynosi: " + PlayerPrefsController.GetDifficulty());
        numberOfHearts = (int)health;
    }
    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite= fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    public void TakeLife()
    {
        health -= damage;

        if(health <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
