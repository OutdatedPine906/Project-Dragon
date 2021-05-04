using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition : MonoBehaviour
{
    public int target;
    public bool local;
    public float warpX;
    public float warpY;

    public GameObject player;
    public GameObject key;

    //<summary>
    // moves player to correct scene and position
    //</summary>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if(local == true)
        {
            player.transform.position = new Vector2(warpX, warpY);

        }
        else
        {
            SceneManager.LoadScene(target);
            player.transform.position = new Vector2(warpX, warpY);
            player.GetComponent<transition_manager>().Transition();
            
        }
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        
    }
}
