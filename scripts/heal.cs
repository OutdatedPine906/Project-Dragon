using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal : MonoBehaviour
{
    public GameObject Player;
    public GameObject Self;

     void OnTriggerEnter2D(Collider2D collision)
    {
        Player = GameObject.FindGameObjectWithTag("player");
        Player.GetComponent<transition_manager>().Names.Add(self.name);
        Player.GetComponent<player_interactivity>().ManageHealth(false, true, Random.RandomRange(2, 3));
        Self.active = false;
    }
}
