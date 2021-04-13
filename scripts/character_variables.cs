using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class character_variables : MonoBehaviour
{
    public GameObject player;


    
   
    //variables
    public int power = 4;
    [Range(0, 10)]public int health = 5;
    public int crystals = 0;
    //UI elements
    public Text power_text;
    public Text health_text;
    public Text crystal_text;

    //displaying variables on UI
    public void Update()
    {
        power_text.text = "POWER: " + power;
        health_text.text = "HEALTH: " + health;
        crystal_text.text = crystals.ToString();
        ifs();
        
    }

    public void Start()
    {
       
    }


    public void ifs()
    {
        if(health <= 0)
        {
            player.GetComponent<player_interactivity>().ManageDeath("health");
        }
    }

   
}
