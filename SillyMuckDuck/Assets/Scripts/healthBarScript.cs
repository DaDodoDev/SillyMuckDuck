using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthBarScript : MonoBehaviour
{
    public Slider healthSlider;

    public void SetMaxHealth(int maxHealth)
    {
        healthSlider.maxValue = maxHealth;
    }

    public void SetHealth(int health)
    {
        healthSlider.value = health; 
    }
}
