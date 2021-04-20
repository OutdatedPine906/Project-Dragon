
using UnityEngine;
using UnityEngine.UI;

public class ability_manager : MonoBehaviour
{

    public GameObject Player;

    public GameObject DBJimg;
    public GameObject TBJimg;
    public Text DBJtext;
    public Text TBJtext;

     void Update()
    {
        if(Player.GetComponent<player_movement>().Airjumpmax == 1)
        {
            DBJtext.text = "Double Jump";
            DBJimg.active = false;

        }
        else
        {
            if (Player.GetComponent<player_movement>().Airjumpmax == 2)
            {
                TBJtext.text = "Tripple Jump";
                TBJimg.active = false;
            }
        }

        
    }
    
}
