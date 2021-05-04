using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    private int health;
    [SerializeField]private int health_max;
    public GameObject enemy;
    public bool isdead;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        health = health_max;
        player = GameObject.FindGameObjectWithTag("player");
    }

    //<summary>
    // destroys enemies that ran out of health and increases player power
    //</summary>
    void Update()
    {
        if(health == 0)
        {
            enemy.active = false;
            isdead = true;
            player.GetComponent<character_variables>().power += 1;

        }
    }

    //<summary>
    // decreases enemy healthy by damage
    //</summary>
    public void takedmg(int amount)
    {
        health -= amount;
    }
}
