using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public GameController GM;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collison: Exit");
        GM.passDay();
    }
}
