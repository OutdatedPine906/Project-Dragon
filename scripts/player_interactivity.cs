using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_interactivity : MonoBehaviour
{
    public GameObject player;
    public bool isdead = false;

    public GameObject[] UIs;

    public float respointX;
    public float respointY;

    public GameObject pause;
    public GameObject viewer;

    public bool noUI;

    public int healthmax = 5;

    public GameObject dmgparticle;

    public GameObject canvas;
    public GameObject ESystem;

    public int respoint_sceneID;

    public  bool OtherScene;

    public void Update()
    {
        if (player.transform.position.y <= -30)
        {
            ManageDeath("fall");
        }

       if (Input.GetKeyDown(KeyCode.Escape))
        {
            for (int i = 0; i < UIs.Length; i++)
            {
                UIs[i].active = false;
                noUI = true;
            }

            if(noUI = true)
            {
                pause.active = false;
                noUI = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            viewer.active = true;
            player.GetComponent<player_interactivity>().UI();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            UIs[0].active = true;
        }
    }

    public void UI()
    {
        noUI = false;
    }

    public void ManageHealth(bool damage, bool health, int amount)
    {
        if(damage == true)
        {
            player.GetComponent<character_variables>().health -= amount;
            dmgparticle.active = true;
            Invoke("particle_off", 0.05f);
        }
        else
        {
            if(health == true)
            {
                player.GetComponent<character_variables>().health += amount;
            }
        }
    }

    public void ManageDeath(string type)
    {

        if (OtherScene == true)
        {
            SceneManager.LoadScene(respoint_sceneID);
        }
        player.transform.position = new Vector3(respointX, respointY, 0);
        Debug.Log(type);
        

        if(type == "health")
        {
            player.GetComponent<character_variables>().health = healthmax;
        }
    }

    public void quit()
    {
        Application.Quit();
    }

    public void particle_off()
    {
        dmgparticle.active = false;
    }

    private void Awake()
    {
        DontDestroyOnLoad(player);
        DontDestroyOnLoad(canvas);
        DontDestroyOnLoad(ESystem);
        
    }
}
