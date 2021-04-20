using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class external_health : MonoBehaviour
{
    public GameObject Player;

    void OnTriggerEnter2D(Collider2D Collision)
    {

        Player.GetComponent<player_interactivity>().ManageHealth(true, false, 1);
    }

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("player");
    }
}
