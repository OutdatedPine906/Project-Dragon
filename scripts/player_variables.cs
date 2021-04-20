using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_variables : MonoBehaviour
{
    public GameObject Player;


    
   
    //variables
    public int Power = 4;
    [Range(0, 10)]public int Health = 5;
    public int Crystals = 0;
    //UI elements
    public Text Power_text;
    public Text Health_text;
    public Text Crystal_text;

    //displaying variables on UI
    public void Update()
    {
        Power_text.text = "POWER: " + Power;
        Health_text.text = "HEALTH: " + Health;
        Crystal_text.text = Crystals.ToString();
        Ifs();
        
    }

    public void Start()
    {
       
    }


    public void Ifs()
    {
        if(Health <= 0)
        {
            Player.GetComponent<Player_interactivity>().ManageDeath("health");
        }
    }

   
}
