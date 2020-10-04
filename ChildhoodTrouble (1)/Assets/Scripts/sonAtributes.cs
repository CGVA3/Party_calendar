using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum SocialGroup
{
    emo,
    punk,
    geek,
    gamer,
    popular,
    neutral
}
//0-5
enum Sport
{
    baseball,
    football,
    soccer,
    tennis,
    basquetball,
    swimming
}
//0-5

enum Music
{
    pop,
    rock,
    metal,
    reggaeton,
    LoFi,
    emo
}
//0-5
enum Food
{
    junkFood,
    healthy,
    vegan,
    mexican,
    seafood,
    chinese
}



public class sonAtributes : MonoBehaviour
{
    // Start is called before the first frame update
    public int Social;
    public int Sport;
    public int Music;
    public int Food;
    public int Tension;
    
    //0-5


    void Start()
    {
        Social = UnityEngine.Random.Range(0, 5); // 
        Sport = UnityEngine.Random.Range(0, 5);
        Music = UnityEngine.Random.Range(0, 5);
        Food = UnityEngine.Random.Range(0, 5);
        Tension = UnityEngine.Random.Range(0, 5);



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
