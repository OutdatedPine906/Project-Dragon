using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatInput : MonoBehaviour
{
    private List<string> Commands = new List<string> { "cheat-debug", "tools-enable", "tools-disable" };


    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        var se = new InputField.SubmitEvent();
        se.AddListener(Submit);
        input.onEndEdit = se;

    }

    private void Submit(string arg0)
    {
       for(int i = 0; i > Commands.ToArray().Length; i++)
       {
          if(arg0 == Commands[i])
          {
                if(arg0 == "cheat-debug")
                {
                    print("cheats enabled");
                }
          }
       }
    }
}
