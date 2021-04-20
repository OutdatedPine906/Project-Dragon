using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power : MonoBehaviour
{
    public GameObject Player;
    public GameObject Self;
    public int Amount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.GetComponent<transition_manager>().Names.Add(Self.name);
        Player.GetComponent<player_variables>().Power += Amount;
        Self.active = false;
    }

    public void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("player");
        Amount = Random.RandomRange(1, 3);
    }
}
