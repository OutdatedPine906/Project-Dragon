using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class transition_manager : MonoBehaviour
{
    public List<string> Names = new List<string>();
    public List<GameObject> GameObjects = new List<GameObject>();
    public List<string> Used_names = new List<string>();
    public List<GameObject> Used = new List<GameObject>();



    public void Transition()
    {
        for (int i = 0; i < gameObjects.ToArray().Length; i++)
        {
            GameObject.Destroy(gameObjects[i]);
        }

        for (int i = 0; i < Used.ToArray().Length; i++)
        {
            Used[i].GetComponent<dbj_add>().Used = true;
        }
    }

    private void Update()
    {
        for (int i = 0; i < names.ToArray().Length; i++)
        {

            if (GameObject.Find(names[i]) != null)
            {
                gameObjects.Add(GameObject.Find(names[i]));
            }

        }

        for (int i = 0; i < Used_names.ToArray().Length; i++)
        {

            if (GameObject.Find(Used_names[i]) != null)
            {
                Used.Add(GameObject.Find(Used_names[i]));
            }

        }

    }
}
