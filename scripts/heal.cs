using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal : MonoBehaviour
{
    public GameObject player;
    public GameObject self;

     void OnTriggerEnter2D(Collider2D collision)
    {
        player = GameObject.FindGameObjectWithTag("player");
        player.GetComponent<player_interactivity>().ManageHealth(false, true, Random.RandomRange(2, 3));
        self.active = false;
    }
}
