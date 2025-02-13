//Michael Anglemier, following "Bug Free Productions" tutorial

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBrick : MonoBehaviour
{
    // Vars

    [SerializeField, Range(1, 20)] protected int hitsToBreak;
    [SerializeField, Range(1, 20)] protected int pointValue;

    protected int curHitsToBreak;

    //break emitter
    //[SerializeField] GameObject ps_Prefab;
    [SerializeField] ParticleSystem hit_PS;

    //Methods

    private void Awake()
    {
        curHitsToBreak = hitsToBreak;
    }

    public void Break(int aDamage)
    {
        curHitsToBreak -= aDamage;

        hit_PS.Play();

        BreakBrick();
    }

    protected void BreakBrick()
    {
        if (curHitsToBreak <= 0)
        {
            //Add flare before destroy
            
            //FindObjectOfType<RoundManager>().RemoveBrick(this);

            GameManager.Instance.AddScore(pointValue);

            //Instantiate(ps_Prefab).GetComponent<ParticleSystem>().Play();

            

            Destroy(gameObject);
            
            //Too late to add destructive flare
        }
    }


    //Accessors

}
