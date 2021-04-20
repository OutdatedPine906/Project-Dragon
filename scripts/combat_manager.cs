
using UnityEngine;

public class combat_manager : MonoBehaviour
{
    public Collider2D BoxCollider;
    public float Range;

    public LayerMask Enemymask;

    public int Melee_dmg = 1;

    public string Facing;
    public GameObject Player;

    public int Attack_wait;
    public int Attack_wait_base;

    public void Update()
    {
        Facing = Player.GetComponent<player_movement>().Direction;

        if (Input.GetMouseButtonDown(0)&& Attack_wait <= 0)
        {
            if(Facing == "left")
            {
                RaycastHit2D RaycastHit2d = Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0f, Vector2.left, Range, Enemymask);
                if (RaycastHit2d != null)
                {
                    RaycastHit2d.transform.GetComponent<enemyscript>().Takedmg(Melee_dmg);
                }
            }

            if(Facing == "right")
            {
                RaycastHit2D RaycastHit2d = Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0f, Vector2.right, Range, Enemymask);
                if (RaycastHit2d != null)
                {
                    RaycastHit2d.transform.GetComponent<enemyscript>().Takedmg(Melee_dmg);
                }
            }

            Attack_wait = Attack_wait_base;
            InvokeRepeating("minus", 0.0f, 1);
        }
    }

    public void Start()
    {
        Facing = Player.GetComponent<player_movement>().Direction;
        
    }

    private void Minus()
    {
       Attack_wait--;
    }
    


}
