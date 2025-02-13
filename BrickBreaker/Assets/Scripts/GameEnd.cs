//Michael Anglemier, following "Bug Free Productions" tutorial

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    //Methods
    private void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.StartScene();
    }
}
