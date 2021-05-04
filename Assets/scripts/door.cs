
using UnityEngine;

public class door : MonoBehaviour
{
    [SerializeField]private int sockets;
    [SerializeField]private int activated_sockets;
    public GameObject[] activated_socket_array;
    public GameObject self;

    //<summary>
    // self-destructs if all sockets are activateed
    //</summary>
    void Update()
    {
        if(sockets == activated_sockets)
        {
            self.active = false;

        }
    }

    //<summary>
    // increases number of activated sockets depending on array 
    //</summary>
    public void activate_sockets()
    {
        activated_socket_array[0].active = true;
        activated_sockets += 1;
    }
}
