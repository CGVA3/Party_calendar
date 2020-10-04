using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    

  
    public static void saveAtributes(sonAtributes Son)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string pathAtributes = Application.persistentDataPath + "/atributes.fun";
        FileStream streamAtributes = new FileStream(pathAtributes, FileMode.Create);

        SonData atributesOfSon = new SonData(Son);
        formatter.Serialize(streamAtributes, atributesOfSon);
        Debug.Log("file saved in: " + pathAtributes);
        streamAtributes.Close();
    }
    
    public static SonData loadAtributes()
    {
        
        string path = Application.persistentDataPath + "/atributes.fun";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SonData data = formatter.Deserialize(stream) as SonData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("Error loading atributes");
            return null;
        }
    }

    public static void saveGame(GameController GM)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string pathAtributes = Application.persistentDataPath + "/gameController.fun";
        FileStream streamAtributes = new FileStream(pathAtributes, FileMode.Create);

        GameState data = new GameState(GM);
        formatter.Serialize(streamAtributes, data);
        Debug.Log("file saved in: " + pathAtributes);
        streamAtributes.Close();
    }

    public static GameState loadGame()
    {

        string path = Application.persistentDataPath + "/gameController.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameState data = formatter.Deserialize(stream) as GameState;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("Error loading atributes");
            return null;
        }
    }

}
