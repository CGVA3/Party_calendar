using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SaveStation : MonoBehaviour
{
    // Start is called before the first frame update

    public GameController GM;
    public sonAtributes SA;
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (EditorUtility.DisplayDialog("Saving", "Do you wan to saved the game?", "Continue", "Cancel"))
        {
            Debug.Log("Collision: Save Station");
            SaveSystem.saveAtributes(SA);
            SaveSystem.saveGame(GM);
        }

        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
