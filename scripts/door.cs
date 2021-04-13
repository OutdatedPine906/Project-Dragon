
using UnityEngine;

public class door : MonoBehaviour
{
    [SerializeField]private int sockets;
    [SerializeField]private int activated_sockets;
    public GameObject[] activated_socket_array;
    public GameObject self;

    // Update is called once per frame
    void Update()
    {
        if(sockets == activated_sockets)
        {
            self.active = false;

        }
    }

    public void activate_sockets()
    {
        activated_socket_array[0].active = true;
        activated_sockets += 1;
    }
}
