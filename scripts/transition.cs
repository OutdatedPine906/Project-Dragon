using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition : MonoBehaviour
{
    public int Target;
    public bool Local;
    public float WarpX;
    public float WarpY;

    public GameObject Player;
    public GameObject Key;

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        

        if(Local == true)
        {
            Player.transform.position = new Vector2(WarpX, WarpY);

        }
        else
        {
            SceneManager.LoadScene(Target);
            Player.transform.position = new Vector2(WarpX, WarpY);
            Player.GetComponent<transition_manager>().Transition();
            
        }
    }

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("player");
        
    }
}

