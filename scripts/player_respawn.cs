using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_respawn : MonoBehaviour
{
    public float Xpos;
    public float Ypos;

    private int SceneID;

    public Transform Respoint;
    public GameObject Player;

    public bool Isactive = false;

    

    public GameObject Particle;

    public bool IsOtherScene;

    // Start is called before the first frame update
    private void Update()
    {
        

        if(SceneManager.GetActiveScene().buildIndex != SceneID)
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
        if (Player.GetComponent<player_variables>().Power >= 1)
        {
            if(Isactive == false)
            {
                Player.GetComponent<player_variables>().Power -= 1;
                Player.GetComponent<player_interactivity>().ManageHealth(false, true, 1);
            }

            Player.GetComponent<player_interactivity>().RespointX = Respoint.position.x;
            Player.GetComponent<player_interactivity>().RespointY = Respoint.position.y + 2;
            Player.GetComponent<player_interactivity>().Respoint_sceneID = SceneID;
            Player.GetComponent<player_interactivity>().OtherScene = IsOtherScene;

            Isactive = true;

            Particle.active = true;
        }

        

        Debug.Log("in trigger");
    }


    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("player");
        SceneID = SceneManager.GetActiveScene().buildIndex;
    }

    
}
