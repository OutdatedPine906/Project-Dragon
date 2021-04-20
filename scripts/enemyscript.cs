using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour
{
    private int Health;
    [SerializeField]private int Health_max;
    public GameObject Enemy;
    public bool Isdead;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Health = Health_max;
        Player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Health == 0)
        {
            Enemy.active = false;
            Isdead = true;
            Player.GetComponent<player_variables>().Power += 1;

        }
    }

    public void Takedmg(int Amount)
    {
        Health -= Amount;
    }
}
