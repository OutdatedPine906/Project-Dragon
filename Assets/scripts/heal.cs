using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal : MonoBehaviour
{
    public GameObject player;
    public GameObject self;

    //<summary>
    // increases player health by a random number
    //</summary>
    void OnTriggerEnter2D(Collider2D collision)
    {
        player = GameObject.FindGameObjectWithTag("player");
        player.GetComponent<transition_manager>().names.Add(self.name);
        player.GetComponent<player_interactivity>().ManageHealth(false, true, Random.RandomRange(2, 3));
        self.active = false;
    }
}
