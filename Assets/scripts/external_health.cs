using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class external_health : MonoBehaviour
{
    public GameObject player;

    //<summary>
    // decreases player health by 1
    //</summary>
    void OnTriggerEnter2D(Collider2D collision)
    {

        player.GetComponent<player_interactivity>().ManageHealth(true, false, 1);
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }
}
