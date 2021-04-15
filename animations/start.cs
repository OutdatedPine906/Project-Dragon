using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = GameObject.FindGameObjectWithTag("player");

        player.GetComponent<character_variables>().power = 5;
        player.GetComponent<character_variables>().health = 5;
        player.GetComponent<character_variables>().crystals = 0;
    }
}
