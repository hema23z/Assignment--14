using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        Character character = new Character();
        Enemy enemy = new Enemy();
        Player player = new Player();

        player.Heal(20);
        enemy.Attack(50);

        Debug.Log("Character Health=" + " " + character.Health);
        Debug.Log("player  Health=" + " " + player.Health);
        Debug.Log("enemy Health=" + " " + enemy.Health);
        Debug.Log("end Health=" + " " + character.Health);

    }


    void Update()
    {

    }

}
