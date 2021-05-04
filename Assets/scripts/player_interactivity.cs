using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class player_interactivity : MonoBehaviour
{
    PlayerControls controls;

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

       if (controls.UI.Exit.triggered)
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

        if (controls.UI.viewer.triggered)
        {
            UIs[0].active = true;
            UI();
        }

        if (controls.UI.cheat_menu.triggered)
        {
            UIs[1].active = true;
            UI();
        }

    }

    public void UI()
    {
        noUI = false;
    }

    //<summary>
    // adjusts player health depending on damage and health gain
    //</summary>
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

    //<summary>
    // returns player to respoint and maxes health at death
    //</summary>
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
        controls = new PlayerControls();
    }

    void OnEnable()
    {
        controls.UI.Enable();
    }

    void OnDisable()
    {
        controls.UI.Disable();
    }
}
