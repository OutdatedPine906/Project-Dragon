
using UnityEngine;

public class door : MonoBehaviour
{
    [SerializeField]private int Sockets;
    [SerializeField]private int Activated_sockets;
    public GameObject[] Activated_socket_array;
    public GameObject Self;

    // Update is called once per frame
    void Update()
    {
        if(Sockets == Activated_sockets)
        {
            Self.active = false;

        }
    }

    public void Ativate_sockets()
    {
        Activated_socket_array[0].active = true;
        Activated_sockets += 1;
    }
}
