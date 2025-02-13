//Michael Anglemier, following "Bug Free Productions" tutorial
// 1/23/2024

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasNav : MonoBehaviour
{
    // Vars
    //[SerializeField]

    //Methods
    public void LoadNextScene()
    {
       

        GameManager.Instance.NextScene();

        //SceneManager.LoadScene(aIDX);
    }

    public void LoadStartScreen()
    {
        //GameManager.Instance.ResetScore();

        //LoadNextScene(0);

        GameManager.Instance.StartScene();
    }

    //Accessors
}
