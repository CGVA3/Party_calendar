using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonExp : MonoBehaviour
{
    public int type;
    


    void OnMouseDown()
    {
        if(type == 1)
        {

            PointController.Social++;
        }
        else if(type == 2)
        {
            PointController.Sport++;
        }
        else if (type == 3)
        {
            PointController.Music++;
        }
        else if (type == 4)
        {
            PointController.Food++;
        }
        else
        {
            int typeRange = UnityEngine.Random.Range(1, 4);
            switch (typeRange)
            {
                case 1:
                    PointController.Social--;
                    break;
                case 2:
                    PointController.Sport--;
                    break;
                case 3:
                    PointController.Music--;
                    break;
                case 4:
                    PointController.Food--;
                    break;
            }
        }
        Destroy(this.gameObject);

    }
}
