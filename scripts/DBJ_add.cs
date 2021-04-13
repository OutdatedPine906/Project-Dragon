using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBJ_add : MonoBehaviour
{
    public GameObject character;
    public SpriteRenderer colorGO;
    public Color disabledcol;
    public GameObject particle;
    public bool used = false;
    public GameObject upgrade;

    void OnTriggerEnter2D()
    {
        character = GameObject.FindGameObjectWithTag("player");
        upgrade = GameObject.FindGameObjectWithTag("panel");

        if (used == false)
        {
            character.GetComponent<player_movement>().add();
            character.GetComponent<transition_manager>().used.Add(upgrade);
            colorGO.color = disabledcol;
            particle.active = false;
            used = true;
            upgrade.active = true;
            upgrade.GetComponent<Animator>().enabled = true;
        }
        
    }

    public void Update()
    {
        if(used == true)
        {
            colorGO.color = disabledcol;
            particle.active = false;
        }
    }
}
