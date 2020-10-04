using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeAtributes : MonoBehaviour
{
    bool atributesVisible = false;
    public Canvas cv;

    public void setAtrVisible()
    {
        Debug.Log("Atributos Enable");
        cv.enabled = true;
        
    }
}
