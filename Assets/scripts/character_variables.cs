using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class character_variables : MonoBehaviour
{
    public GameObject Player;

    //cheat variables
    public int StoredHealth;

    //variables
    public int power = 4;
    public int health = 5;
    public int crystals = 0;
    //UI elements
    public Text power_text;
    public Text health_text;
    public Text crystal_text;

    //displaying variables on UI
    public void Update()
    {
        power_text.text = "POWER: " + power;
        crystal_text.text = crystals.ToString();
        Ifs();
        
    }

    public void Start()
    {
       
    }


    public void Ifs()
    {
        if(health <= 0 )
        {
            Player.GetComponent<player_interactivity>().ManageDeath("health");
        }

        if(Player.GetComponent<combat_manager>().Invincibility == true)
        {
            health_text.text = "HEALTH: N/A";
            health = 10000;

        }
        else
        {
            health_text.text = "HEALTH: " + health;
        }
    }

   
}
