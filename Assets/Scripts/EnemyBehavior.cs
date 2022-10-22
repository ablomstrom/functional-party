using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehavior : MonoBehaviour
{
    public Image healthBarImage;
    private float maxHealth;
    private float health;

    readonly private float visionRadius;


    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space)) { 
        
            takeDamage(1);
        }
    }

    void takeDamage(int dmg)
    {
        health = this.health - dmg;
        UpdateHealthBar();
    }


    public void UpdateHealthBar()
    {
        healthBarImage.fillAmount = Mathf.Clamp( health/ maxHealth, 0, 1f);
    }

}
