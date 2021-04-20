using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_interactivity : MonoBehaviour
{
    public GameObject Player;
    public bool Isdead = false;

    public GameObject[] UIs;

    public float RespointX;
    public float RespointY;

    public GameObject Pause;
    public GameObject Viewer;

    public bool NoUI;

    public int Healthmax = 5;

    public GameObject Dmgparticle;

    public GameObject Canvas;
    public GameObject ESystem;

    public int Respoint_sceneID;

    public  bool OtherScene;

    public void Update()
    {
        if (Player.transform.position.y <= -30)
        {
            ManageDeath("fall");
        }

       if (Input.GetKeyDown(KeyCode.Escape))
        {
            for (int i = 0; i < UIs.Length; i++)
            {
                UIs[i].active = false;
                NoUI = true;
            }

            if(NoUI = true)
            {
                pause.active = false;
                NoUI = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Viewer.active = true;
            Player.GetComponent<player_interactivity>().UI();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            UIs[0].active = true;
        }
    }

    public void UI()
    {
        NoUI = false;
    }

    public void ManageHealth(bool Damage, bool Health, int Amount)
    {
        if(Damage == true)
        {
            player.GetComponent<player_variables>().Health -= Amount;
            Dmgparticle.active = true;
            Invoke("particle_off", 0.05f);
        }
        else
        {
            if(Health == true)
            {
                player.GetComponent<player_variables>().Health += Amount;
            }
        }
    }

    public void ManageDeath(string Type)
    {

        if (OtherScene == true)
        {
            SceneManager.LoadScene(Respoint_sceneID);
        }
        Player.transform.position = new Vector3(RespointX, RespointY, 0);
        Debug.Log(Type);
        

        if(Type == "health")
        {
            Player.GetComponent<player_variables>().Health = Healthmax;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Particle_off()
    {
        Dmgparticle.active = false;
    }

    private void Awake()
    {
        DontDestroyOnLoad(Player);
        DontDestroyOnLoad(Canvas);
        DontDestroyOnLoad(ESystem);
        
    }
}
