using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij AstroWorld");
        Terminal.WriteLine("Dit is gebaseerd op een waargebeurd verhaal");
        Terminal.WriteLine("Typ start om te beginnen");
    }

    void OnUserInput(string input)
    {
        if (input == "start")
        {
            StartIntro();
        }else if (input == "6969")
        {
            Terminal.WriteLine("Epic!");
        }
        else
        {
            Terminal.WriteLine("Verkeerde invoer");
        }
    }

    void StartIntro()
    {
        Terminal.WriteLine("Het was een rustige dag in het RuimteSchip");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
