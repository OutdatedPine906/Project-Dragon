using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class transition_manager : MonoBehaviour
{
    public List<string> names = new List<string>();
    public List<GameObject> gameObjects = new List<GameObject>();
    public List<string> used_names = new List<string>();
    public List<GameObject> used = new List<GameObject>();

    public void Transition()
    {
        for (int i = 0; i < gameObjects.ToArray().Length; i++)
        {
            GameObject.Destroy(gameObjects[i]);
        }

        for (int i = 0; i < used.ToArray().Length; i++)
        {
            used[i].GetComponent<DBJ_add>().used = true;
        }
    }

    //<summary>
    // gives the player infinite health
    //</summary>
    private void Update()
    {
        for (int i = 0; i < names.ToArray().Length; i++)
        {

            if (GameObject.Find(names[i]) != null)
            {
                gameObjects.Add(GameObject.Find(names[i]));
            }

        }

        for (int i = 0; i < used_names.ToArray().Length; i++)
        {

            if (GameObject.Find(used_names[i]) != null)
            {
                used.Add(GameObject.Find(used_names[i]));
            }

        }

    }
}
