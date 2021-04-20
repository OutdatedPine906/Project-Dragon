using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public LayerMask PlatformlayerMask;
    public Rigidbody2D Rigidbody;
    public float Jumpvel = 10f;
    public BoxCollider2D BoxCollider;
    public float Movespeed = 10f;
    [SerializeField]private int Airjump = 0;
    public int Airjumpmax = 0;
    public SpriteRenderer Renderer;
    public Color Jumpcol;
    public Color Defcol;
    public float Boostvel = 5;
    public string Direction;
    public bool Coyote_time;
    public float Coyote_time_base;
    public float Jumpvel_k;
    public int RespointID;
    public static int Active_respoint;



    // Update is called once per frame
    void Update()
    {
        //jumping
        if (IsGrounded())
        {
            Airjump = 0;
            Renderer.color = Jumpcol;
            Coyote_time = true;
            
        }

        if (Input.GetButton("Jump"))
        {
            if (IsGrounded())
            {
                Rigidbody.velocity = Vector2.up * Jumpvel;
            }
            else
            {
                if (IsNotGrounded() && Coyote_time == true)
                {
                    Rigidbody.velocity = Vector2.up * Jumpvel;
                }
                else
                {
                    if (Airjump < Airjumpmax && Input.GetButtonDown("Jump"))
                    {
                        Rigidbody.velocity = Vector2.up * Jumpvel;
                        Airjump++;

                    }
                }
            }
        }

        HandleMovement();

        if (Airjumpmax >= 1)
        {
            if (Airjump == Airjumpmax)
            {
                Renderer.color = Defcol;
            }
        }
        else
        {
            Renderer.color = Jumpcol;
        }

        if (IsNotGrounded())
        {
            Invoke("Coyote_time_handle", Coyote_time_base);
           
        }

        
    }
    void Awake()
    {
        Coyote_time_base = 0.15f;
        Jumpvel_k = Jumpvel * 0.8f;
    }

    private bool IsGrounded()
    {
       RaycastHit2D RaycastHit2d =  Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0f, Vector2.down, .1f, PlatformlayerMask);
       return RaycastHit2d.collider != null;

    }
    private bool IsNotGrounded()
    {
        RaycastHit2D RaycastHit2d = Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0f, Vector2.down, .1f, PlatformlayerMask);
        return RaycastHit2d.collider == null;

    }

    //movement
    public void HandleMovement()
    {
       

        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody.velocity = new Vector3(-Movespeed, Rigidbody.velocity.y);
            Direction = "left";
        }
        else
        {
            if (Input.GetKey(KeyCode.D))
            {
              Rigidbody.velocity = new Vector3(+Movespeed, Rigidbody.velocity.y);
                Direction = "right";
            }
            else
            {
                //no keys pressed
                Rigidbody.velocity = new Vector3(0, Rigidbody.velocity.y);
            }
        }
        
    }

    public void Add()
    {
        Airjumpmax += 1;
    }

    public void Reset()
    {
        Airjump = 0;
    }

    public void Jump()
    {
        Rigidbody.velocity = Vector2.up * Boostvel;
    }

    public void Coyote_time_handle()
    {
        Coyote_time = false;
    }

   
}
