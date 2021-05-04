using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_movement : MonoBehaviour
{

    PlayerControls controls;

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

    float move;
    float FlyMove;
    public bool Fly = false;


    //<summary>
    // handles vertical and horizontal player movement
    //</summary>
    void Update()
    {
        HandleMovement();

        if (Fly == false)
        {

            //jumping
            if (IsGrounded())
            {
                airjump = 0;
                renderer.color = jumpcol;
                coyote_time = true;

            }

            if (controls.movement.jump.triggered)
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
                        if (airjump < airjumpmax && controls.movement.jump.triggered)
                        {
                            rigidbody.velocity = Vector2.up * jumpvel;
                            airjump++;

                        }
                    }
                }
            }


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
        else
        {
            HandleFly();
        }
    }

    void Awake()
    {
        coyote_time_base = 0.15f;
        jumpvel_k = jumpvel * 0.8f;
        controls = new PlayerControls();
        controls.movement.move.performed += ctx => move = ctx.ReadValue<float>();
        controls.movement.fly.performed += ctx => FlyMove = ctx.ReadValue<float>();
        controls.movement.move.canceled += ctx => move = 0;
        controls.movement.fly.canceled += ctx => FlyMove = 0;
    }

    //<summary>
    // returns whether player is on the ground or not
    //</summary>
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

    //<summary>
    // moves player left or right depending on move value
    //</summary>
    public void HandleMovement()
    {
       

        if (move < 0)
        {
            rigidbody.velocity = new Vector3(-movespeed, rigidbody.velocity.y);
            direction = "left";
        }
        else
        {
            if ( move > 0)
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

    //<summary>
    // moves player up and down depending on FlyMove value
    //</summary>
    void HandleFly()
    {
        if (FlyMove > 0)
        {
            rigidbody.velocity = Vector2.up * movespeed;
        }
        else
        {
            if (FlyMove < 0)
            {
                rigidbody.velocity = Vector2.down * movespeed;
            }
            else
            {
                rigidbody.velocity = new Vector2(0, 0);
            }
           
        }

        HandleMovement();
    }


    public void AddJump()
    {
        airjumpmax += 1;
    }

    public void RemoveJump()
    {
        airjumpmax -= 1;
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


    void OnEnable()
    {
        controls.movement.Enable();
    }

    void OnDisable()
    {
        controls.movement.Disable();
    }

    public void SetFly(bool value)
    {
        Fly = value;
    }

    public void SetNoclip(bool value)
    {
       BoxCollider.enabled = !value;
    }

    public void SetToOneJump()
    {
        airjumpmax = 0;
    }
}
