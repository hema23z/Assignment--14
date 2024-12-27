using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class Character
{

    private int health =100;
    private string name = "";




    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Health
    {
        get { return health; }
        set
        {
            if (value > 100) health = 100;
            else if (value < 0) health = 0;
            else health = value;
        }
    }
    public Character(string name, int health)
    {
        this.name = name;
        this.health = health;
    }
     public Character() :this("",100 )
     {
     }
  

    
}




