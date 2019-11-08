using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using Random = UnityEngine.Random;

public class MyAdventure : MonoBehaviour
{

    private enum States
    {
        Mainmenu,
        Gamestart,
        controls,
        credits,
    }

    private States currentState = States.Mainmenu;

    // Start is called before the first frame update
    void Start()
    {
        Mainmenu();
    }

    
   

    // Update is called once per frame
    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case States.Mainmenu:
                if (input == "Start")
                {
                    GameStart();
                }
                else if (input == "controls")
                {
                    controls();
                }
                else if (input == "credits")
                {
                    credits();
                }
                else
                {
                    Mainmenu();
                }
        }
    }

    void Mainmenu()
    {
        currentState = States.Mainmenu;
        
    }

    void GameStart()
    {

    }

    void controls()
    {

    }

    void credits()
    {

    }
}
