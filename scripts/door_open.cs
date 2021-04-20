using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_open : MonoBehaviour
{
    public GameObject Door;
    public GameObject Self;
    public GameObject Player;

    public static List<GameObject> Objects = new List<GameObject>();

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player = GameObject.FindGameObjectWithTag("player");
        Door.SetActive(false);
        Self.GetComponent<SpriteRenderer>().enabled = false;
        Self.GetComponent<CircleCollider2D>().enabled = false;
        Door.tag = "door";
        Player.GetComponent<transition_manager>().Names.Add(Door.name);
        Player.GetComponent<transition_manager>().Names.Add(Self.name);


    }

    private void Update()
    {
        Player = GameObject.FindGameObjectWithTag("player");

        if(Door.active == true)
        {
            if (Door.tag == "door")
            {
                Door.SetActive(false);
                Objects.Add(Door);
                Objects.Add(Self);
            }
        }

        for (int i = 0; i < Player.GetComponent<transition_manager>().GameObjects.ToArray().Length; i++)
        {
            if (Player.GetComponent<transition_manager>().GameObjects[i] != null)
            {
                Player.GetComponent<transition_manager>().GameObjects[i].SetActive(false);
            }
        }
    }

   

}
