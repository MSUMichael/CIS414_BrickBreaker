//Michael Anglemier, following "Bug Free Productions" tutorial

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    //Vars

    //[SerializeField] protected List<BreakableBrick> bricks;

    [SerializeField] protected GameObject canvasScene;

    //Methods

    private void Update()
    {
        //Debug.Log((FindObjectsOfType<BreakableBrick>().Length));

        EndRound();
    }

    private void Awake()
    {
        RoundManager[] gOs = FindObjectsOfType<RoundManager>();

        if (gOs.Length > 1)
        {
            Destroy(gameObject);
        }
    }

    /*
    public void RemoveBrick(BreakableBrick bb)
    {
        bricks.Remove(bb);
    }
    */

    protected void EndRound()
    {
        //Debug.Log((FindObjectsOfType<BreakableBrick>().Length));
        //Debug.Log(bricks.count);

        if (FindObjectsOfType<BreakableBrick>().Length < 1)
        {
            canvasScene.SetActive(true);
        }
    }
}
