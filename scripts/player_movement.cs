using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public LayerMask platformlayerMask;
    public Rigidbody2D rigidbody;
    public float jumpvel = 10f;
    public BoxCollider2D BoxCollider;
    public float movespeed = 10f;
    [SerializeField]private int airjump = 0;
    public int airjumpmax = 0;
    public SpriteRenderer renderer;
    public Color jumpcol;
    public Color defcol;
    public float boostvel = 5;
    public string direction;
    public bool coyote_time;
    public float coyote_time_base;
    public float jumpvel_k;
    public int respointID;
    public static int active_respoint;



    // Update is called once per frame
    void Update()
    {
        //jumping
        if (IsGrounded())
        {
            airjump = 0;
            renderer.color = jumpcol;
            coyote_time = true;
            
        }

        if (Input.GetButton("Jump"))
        {
            if (IsGrounded())
            {
                rigidbody.velocity = Vector2.up * jumpvel;
            }
            else
            {
                if (IsNotGrounded() && coyote_time == true)
                {
                    rigidbody.velocity = Vector2.up * jumpvel;
                }
                else
                {
                    if (airjump < airjumpmax && Input.GetButtonDown("Jump"))
                    {
                        rigidbody.velocity = Vector2.up * jumpvel;
                        airjump++;

                    }
                }
            }
        }

        HandleMovement();

        if (airjumpmax >= 1)
        {
            if (airjump == airjumpmax)
            {
                renderer.color = defcol;
            }
        }
        else
        {
            renderer.color = jumpcol;
        }

        if (IsNotGrounded())
        {
            Invoke("coyote_time_handle", coyote_time_base);
           
        }

        
    }
    void Awake()
    {
        coyote_time_base = 0.15f;
        jumpvel_k = jumpvel * 0.8f;
    }

    private bool IsGrounded()
    {
       RaycastHit2D raycastHit2d =  Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0f, Vector2.down, .1f, platformlayerMask);
       return raycastHit2d.collider != null;

    }
    private bool IsNotGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0f, Vector2.down, .1f, platformlayerMask);
        return raycastHit2d.collider == null;

    }

    //movement
    public void HandleMovement()
    {
       

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.velocity = new Vector3(-movespeed, rigidbody.velocity.y);
            direction = "left";
        }
        else
        {
            if (Input.GetKey(KeyCode.D))
            {
              rigidbody.velocity = new Vector3(+movespeed, rigidbody.velocity.y);
                direction = "right";
            }
            else
            {
                //no keys pressed
                rigidbody.velocity = new Vector3(0, rigidbody.velocity.y);
            }
        }
        
    }

    public void add()
    {
        airjumpmax += 1;
    }

    public void reset()
    {
        airjump = 0;
    }

    public void jump()
    {
        rigidbody.velocity = Vector2.up * boostvel;
    }

    public void coyote_time_handle()
    {
        coyote_time = false;
    }

   
}
