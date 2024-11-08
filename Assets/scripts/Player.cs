using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerZero
{
 public string playerName = "";
public int health = 100;
public static int playerCount = 0;


  public void InitializePlayer(string name, int initialHealth) 
  {
     playerName = name;
     health = initialHealth;
     playerCount++;
  }

public string name()
{
    return playerName;
}

public int initialHealth()
{
    return health; 
}

public int Healthamount()
{
    return health;
}

public void Heal(int value)
{
  health = health + value;
  Debug.Log(playerName + " healed by " + value + ". Current health: " + health);
  
}
public void Heal(bool fullRestore)
{
  if (fullRestore)
  {
    health = 100;
    Debug.Log(playerName + "fully restored health and now ready for action" + health);

  }

}

public static void ShowPlayerCount()
{
Debug.Log("Total number of Player objects: " + playerCount);

}

}