
using UnityEngine;
using UnityEngine.UI;

public class ABILITY_MANAGER : MonoBehaviour
{

    public GameObject player;

    public GameObject DBJimg;
    public GameObject TBJimg;
    public Text DBJtext;
    public Text TBJtext;

     void Update()
    {
        if(player.GetComponent<player_movement>().airjumpmax == 1)
        {
            DBJtext.text = "Double Jump";
            DBJimg.active = false;

        }
        else
        {
            if (player.GetComponent<player_movement>().airjumpmax == 2)
            {
                TBJtext.text = "Tripple Jump";
                TBJimg.active = false;
            }
        }

        
    }
    
}
