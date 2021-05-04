using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystal_get : MonoBehaviour
{
    public GameObject player;
    public GameObject self;
    public int amount;

    //<summary>
    // increases player crystals
    //</summary>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<character_variables>().crystals += amount;
        player.GetComponent<transition_manager>().names.Add(self.name);
        self.active = false;
    }

    public void Awake()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }


}
