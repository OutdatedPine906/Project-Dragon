using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_respawn : MonoBehaviour
{
    public float xpos;
    public float ypos;

    private int sceneID;

    public Transform respoint;
    public GameObject player;

    public bool isactive = false;

    

    public GameObject particle;

    public bool IsOtherScene;

    // Start is called before the first frame update
    private void Update()
    {
        

        if(SceneManager.GetActiveScene().buildIndex != sceneID)
        {
            IsOtherScene = true;
        }
        else
        {
            IsOtherScene = false;
        }
    }


    void OnTriggerEnter2D()
    {
        if (player.GetComponent<character_variables>().power >= 1)
        {
            if(isactive == false)
            {
                player.GetComponent<character_variables>().power -= 1;
                player.GetComponent<player_interactivity>().ManageHealth(false, true, 1);
            }

            player.GetComponent<player_interactivity>().respointX = respoint.position.x;
            player.GetComponent<player_interactivity>().respointY = respoint.position.y + 2;
            player.GetComponent<player_interactivity>().respoint_sceneID = sceneID;
            player.GetComponent<player_interactivity>().OtherScene = IsOtherScene;

            isactive = true;

            particle.active = true;
        }

        

        Debug.Log("in trigger");
    }


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        sceneID = SceneManager.GetActiveScene().buildIndex;
    }

    
}
