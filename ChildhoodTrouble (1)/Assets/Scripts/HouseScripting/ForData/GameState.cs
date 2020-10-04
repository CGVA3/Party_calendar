using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameState
   {
     public int day;
     public int money;

    public GameState(GameController GM)
    {
        day = GM.day;
        money = GM.money;
    }

   };

