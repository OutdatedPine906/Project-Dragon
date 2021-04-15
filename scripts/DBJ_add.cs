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
    public GameObject self;
    public static Dictionary<string, bool> dict = new Dictionary<string, bool> { ["up1"] = false, ["up2"] = false };
    public string ID;

    void OnTriggerEnter2D()
    {
        character = GameObject.FindGameObjectWithTag("player");
        upgrade = GameObject.FindGameObjectWithTag("panel");

        if (dict[ID] == false)
        {

            dict[ID] = true;
            character.GetComponent<player_movement>().add();
            colorGO.color = disabledcol;
            particle.active = false;
            used = true;
            upgrade.active = true;
            upgrade.GetComponent<Animator>().enabled = true;
        }
        
    }

    public void Update()
    {
        if(dict[ID] == true)
        {
            colorGO.color = disabledcol;
            particle.active = false;
        }
    }

    
}
