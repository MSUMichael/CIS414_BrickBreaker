// Michael Anglemier
// 1/23/2024

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //Vars
    private static GameManager instance;
    private float playerScore = 0.0f;


    //Methods


    //Accessors
    public static GameManager Instance 
    { 
        get 
        { 
            if (instance == null)
            {
                GameObject aGO = new GameObject("Game Manager");
                instance = aGO.AddComponent<GameManager>();
                DontDestroyOnLoad(aGO);
            }
            return instance; 
        } 
    }

}
