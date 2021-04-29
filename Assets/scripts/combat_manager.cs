
using UnityEngine;
using UnityEngine.InputSystem;

public class combat_manager : MonoBehaviour
{
    PlayerControls controls;

    //raycasting variables
    public Collider2D BoxCollider;
    public float range;
    public LayerMask enemymask;

    public int melee_dmg = 1;
    

    public string facing;
    public GameObject player;

    public int attack_wait;
    public int attack_wait_base;

    //cheat menu booleans
    public bool Invincibility;
    public bool AutoKill;

    public void Update()
    {
        facing = player.GetComponent<player_movement>().direction;

        if (controls.attack.attack.triggered && attack_wait <= 0)
        {
            if(facing == "left")
            {
                RaycastHit2D raycastHit2d = Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0f, Vector2.left, range, enemymask);
                if (raycastHit2d != false)
                {
                    raycastHit2d.transform.GetComponent<enemyscript>().takedmg(melee_dmg);
                }
            }

            if(facing == "right")
            {
                RaycastHit2D raycastHit2d = Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0f, Vector2.right, range, enemymask);
                if (raycastHit2d != false)
                {
                    raycastHit2d.transform.GetComponent<enemyscript>().takedmg(melee_dmg);
                }
            }

            attack_wait = attack_wait_base;
            InvokeRepeating("minus", 0.0f, 1);
        }

        
    }

    public void Start()
    {
        facing = player.GetComponent<player_movement>().direction;
        
    }

    private void minus()
    {
       attack_wait--;
    }

    private void Awake()
    {
        controls = new PlayerControls();
    }
    
    void OnEnable()
    {
        controls.attack.Enable();
    }

    void OnDisable()
    {
        controls.attack.Disable();
    }


    public void SetAutoKill(bool value)
    {
        AutoKill = value;
        if(value == true)
        {
            melee_dmg = 10000;
        }
        else
        {
            melee_dmg = 1;
        }
    }

    public void SetInvincibility(bool value)
    {
        Invincibility = value;
        character_variables VariableManager;
        VariableManager = player.GetComponent<character_variables>();
        if(value == true)
        {
            VariableManager.StoredHealth = VariableManager.health;
        }
        else
        {
            VariableManager.health = VariableManager.StoredHealth;
            VariableManager.StoredHealth = 0;
        }
            
    }
}
