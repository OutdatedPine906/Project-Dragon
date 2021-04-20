using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dbj_add : MonoBehaviour
{
    public GameObject Player;
    public SpriteRenderer ColorGO;
    public Color Disabledcol;
    public GameObject Particle;
    public bool Used = false;
    public GameObject Upgrade;
    public GameObject Self;
    public static Dictionary<string, bool> Dict = new Dictionary<string, bool> { ["up1"] = false, ["up2"] = false };
    public string ID;

    void OnTriggerEnter2D()
    {
        Player = GameObject.FindGameObjectWithTag("player");
        Upgrade = GameObject.FindGameObjectWithTag("panel");

        if (Dict[ID] == false)
        {

            Dict[ID] = true;
            Player.GetComponent<player_movement>().Add();
            ColorGO.color = Disabledcol;
            Particle.active = false;
            Used = true;
            Upgrade.active = true;
            Upgrade.GetComponent<Animator>().enabled = true;
        }
        
    }

    public void Update()
    {
        if(Dict[ID] == true)
        {
            ColorGO.color = Disabledcol;
            Particle.active = false;
        }
    }

    
}
