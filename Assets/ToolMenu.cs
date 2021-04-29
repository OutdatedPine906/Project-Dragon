using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolMenu : MonoBehaviour
{
    public GameObject Player;

    public Text FPS;
    public Text Vel;
    public Text Coords;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        float GameFPS = 1.0f / Time.deltaTime;
        FPS.text = $"{GameFPS.ToString()} FPS";

        float GameVelX = Player.GetComponent<Rigidbody2D>().velocity.x;
        float GameVelY = Player.GetComponent<Rigidbody2D>().velocity.y;
        Vel.text = $"Vel: {GameVelX.ToString()} : {GameVelY.ToString()} ";

        float X = Player.GetComponent<Transform>().position.x;
        float Y = Player.GetComponent<Transform>().position.y;
        Coords.text = $"Coords: {X.ToString()}, {Y.ToString()} ";
    }

    public void ChangeColor(bool value)
    {
        if(value == false)
        {
            FPS.color = Color.black;
            Vel.color = Color.black;
            Coords.color = Color.black;
        }
        else
        {
            FPS.color = Color.white;
            Vel.color = Color.white;
            Coords.color = Color.white;
        }
       
    }

    

}

    


