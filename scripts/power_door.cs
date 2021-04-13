using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_door : MonoBehaviour
{
    public GameObject player;
    public  int power_required;
    public GameObject DoorObj;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(player.GetComponent<character_variables>().power >= power_required)
        {
            DoorObj.active = false;
            player.GetComponent<character_variables>().power -= 4;
            player.GetComponent<transition_manager>().names.Add(DoorObj.name);
        }
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }
}
