using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class PointController : MonoBehaviour
{
    // Start is called before the first frame update

    public static int Social = 0;
    public static int Food = 0;
    public static int Music = 0;
    public static int Sport = 0;

    public Text SocialTxt;
    public Text FoodTxt;
    public Text MusicTxt;
    public Text SportTxt;

    void Start()
    {
        Social = 0;
        Food = 0;
        Music = 0;
        Sport = 0;
    }
    void Update()
    {
        SocialTxt.text = Social.ToString();
        FoodTxt.text = Food.ToString();
        MusicTxt.text = Music.ToString();
        SportTxt.text = Sport.ToString();
    }
    




}
