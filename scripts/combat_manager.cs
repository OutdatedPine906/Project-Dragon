
using UnityEngine;

public class combat_manager : MonoBehaviour
{
    public Collider2D BoxCollider;
    public float range;

    public LayerMask enemymask;

    public int melee_dmg = 1;

    public string facing;
    public GameObject player;

    public int attack_wait;
    public int attack_wait_base;

    public void Update()
    {
        facing = player.GetComponent<player_movement>().direction;

        if (Input.GetMouseButtonDown(0)&& attack_wait <= 0)
        {
            if(facing == "left")
            {
                RaycastHit2D raycastHit2d = Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0f, Vector2.left, range, enemymask);
                if (raycastHit2d != null)
                {
                    raycastHit2d.transform.GetComponent<enemyscript>().takedmg(melee_dmg);
                }
            }

            if(facing == "right")
            {
                RaycastHit2D raycastHit2d = Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0f, Vector2.right, range, enemymask);
                if (raycastHit2d != null)
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
    


}
