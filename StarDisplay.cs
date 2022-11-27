using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    public int stars = 200;
    Text starText;

    private void Start()
    {
        int starDifficulty = (int)PlayerPrefsController.GetDifficulty();
        starText = GetComponent<Text>();
        stars = stars - (starDifficulty * 25);
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public void SpendStars(int amount)
    {
        if(stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
        else
        {
            Debug.Log("Not enough stars");
        }
    }


}
