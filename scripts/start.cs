using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player = GameObject.FindGameObjectWithTag("player");

        Player.GetComponent<player_variables>().Power = 5;
        Player.GetComponent<player_variables>().Health = 5;
        Player.GetComponent<player_variables>().Crystals = 0;
    }
}
