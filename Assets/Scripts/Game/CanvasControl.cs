using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasControl : MonoBehaviour
{

    public GameObject deadScreen;
    public GameObject firstScreen;

    public void DeadScreen()
    {
        deadScreen.SetActive(true);
    }
     public void FirstScreen()
    {
        firstScreen.SetActive(false);
    }

 
}
