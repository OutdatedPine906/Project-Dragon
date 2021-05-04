using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power : MonoBehaviour
{
    public GameObject player;
    public GameObject self;
    public int amount;

    //<summary>
    // gives the player power before deactivating
    //</summary>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<transition_manager>().names.Add(self.name);
        player.GetComponent<character_variables>().power += amount;
        self.active = false;
    }

    public void Awake()
    {
        player = GameObject.FindGameObjectWithTag("player");
        amount = Random.RandomRange(1, 3);
    }
}
