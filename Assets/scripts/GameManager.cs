using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player2 GrandWarrior = new Player2("Grandwarrior", 80);
        Enemy Zarifeh = new Enemy("Zarifeh", 60);    
        

        GrandWarrior.Heal(15);
        Zarifeh.Attack(GrandWarrior, 20);
    } 


}