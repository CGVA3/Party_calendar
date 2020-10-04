using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawBallon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BallonFood;
    public GameObject BallonSocial;
    public GameObject BallonMusic;
    public GameObject BallonSport;
    public GameObject BallonWrong;
    public GameObject BallonWrong2;
    public GameObject BallonWrong3;
    public GameObject BallonWrong4;

    private Vector2 screenBounds;
    public float respawnTime = 1.0f;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(ballonWave());
    }

    private void spawnBallon()
    {

        int quantity = UnityEngine.Random.Range(0, 5);

        for(int i = 0; i < quantity; i++)
        {
            int type = UnityEngine.Random.Range(1, 8);
            if (type == 1)
                createBallonFood();
            else if (type == 2)
                createBallonMusic();
            else if (type == 3)
                createBallonSocial();
            else if (type == 4)
                createBallonSport();
            else if (type == 5)
                createBallonWrong();
            else if (type == 6)
                createBallonWrong2();
            else if (type == 7)
                createBallonWrong3();
            else if (type == 8)
                createBallonWrong4();
            else
                Debug.LogError("Ballon spawn error");




        }
        

        //a.transform.position = new Vector2(UnityEngine.Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y *-2);
    }
    IEnumerator ballonWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnBallon();
        }
    }

    void createBallonFood()
    {
        GameObject a = Instantiate(BallonFood) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -2);

    }
    void createBallonMusic()
    {
        GameObject a = Instantiate(BallonSocial) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -2);
    }
    void createBallonSport()
    {
        
        GameObject a = Instantiate(BallonSport) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -2);
    }
    void createBallonSocial()
    {
        GameObject a = Instantiate(BallonMusic) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -2);
    }
    void createBallonWrong()
    {
        GameObject a = Instantiate(BallonWrong) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -2);
    }
    void createBallonWrong2()
    {
        GameObject a = Instantiate(BallonWrong2) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -2);
    }
    void createBallonWrong3()
    {
        GameObject a = Instantiate(BallonWrong3) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -2);
    }
    void createBallonWrong4()
    {
        GameObject a = Instantiate(BallonWrong4) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -2);
    }
}
