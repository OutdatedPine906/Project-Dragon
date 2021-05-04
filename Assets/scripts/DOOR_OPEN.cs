using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOOR_OPEN : MonoBehaviour
{
    public GameObject door;
    public GameObject self;
    public GameObject player;

    public static List<GameObject> objects = new List<GameObject>();


    //<summary>
    //deactivate door
    //</summary>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = GameObject.FindGameObjectWithTag("player");
        door.SetActive(false);
        self.GetComponent<SpriteRenderer>().enabled = false;
        self.GetComponent<CircleCollider2D>().enabled = false;
        door.tag = "door";
        player.GetComponent<transition_manager>().names.Add(door.name);
        player.GetComponent<transition_manager>().names.Add(self.name);


    }

    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("player");

        if(door.active == true)
        {
            if (door.tag == "door")
            {
                door.SetActive(false);
                objects.Add(door);
                objects.Add(self);
            }
        }

        for (int i = 0; i < player.GetComponent<transition_manager>().gameObjects.ToArray().Length; i++)
        {
            if (player.GetComponent<transition_manager>().gameObjects[i] != null)
            {
                player.GetComponent<transition_manager>().gameObjects[i].SetActive(false);
            }
        }
    }

   

}
