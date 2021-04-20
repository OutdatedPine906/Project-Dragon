using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystal_get : MonoBehaviour
{
    public GameObject Player;
    public GameObject Self;
    public int Amount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.GetComponent<player_variables>().Crystals += Amount;
        Player.GetComponent<transition_manager>().Names.Add(Self.name);
        Self.active = false;
    }

    public void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("player");
    }


}
