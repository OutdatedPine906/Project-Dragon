using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_door : MonoBehaviour
{
    public GameObject player;
    public  int Power_required;
    public GameObject DoorObj;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(player.GetComponent<player_variables>().Power >= Power_required)
        {
            DoorObj.active = false;
            player.GetComponent<player_variables>().Power -= 4;
            player.GetComponent<transition_manager>().Names.Add(DoorObj.name);
        }
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }
}
