//Michael Anglemier, following "Bug Free Productions" tutorial

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //Vars
    protected Rigidbody rb;

    [SerializeField] protected float worldVelocity = 25;

    [SerializeField] protected Vector3 startForce = Vector3.one;

    [SerializeField] protected int damage = 1;

    //Added sound effect when the ball bounces
    [SerializeField] protected AudioSource audioSource;
    [SerializeField] protected AudioClip audioClip;
    [SerializeField] protected float pitchVariance = 0.15f;

    //Methods
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();

        ApplyStartForce();
    }

    private void FixedUpdate()
    {
        LimitBallVelocity();
    }

    protected void ApplyStartForce()
    {
        rb.AddForce(startForce, ForceMode.Impulse);
    }

    protected void LimitBallVelocity()
    {
        Vector3 hV3 = rb.velocity;
        Vector3 nV3 = Vector3.zero;

        nV3.x = Mathf.Clamp(hV3.x, -worldVelocity, worldVelocity);
        nV3.y = Mathf.Clamp(hV3.y, -worldVelocity, worldVelocity);
        nV3.z = Mathf.Clamp(hV3.z, -worldVelocity, worldVelocity);

        rb.velocity = nV3;
    }

    private void OnCollisionEnter(Collision collision)
    {
        BreakableBrick bb = collision.gameObject.GetComponent<BreakableBrick>();

        PlaySoundWithVariance();

        if (bb != null)
        {
            bb.Break(damage);
        }
    }


    //This allows for subtle pitch variance on sound play so the sound isn't identical everytime
    //after discovering it I apply it to most repeated sounds just because its easy and makes them
    //sound much better if you have to listen to them 30 times rapidly
    //
    public void PlaySoundWithVariance()
    {
        if (audioSource != null && audioClip != null)
        {
            audioSource.clip = audioClip;
            audioSource.pitch = 1.0f + Random.Range(-pitchVariance, pitchVariance);
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource or AudioClip is not assigned.");
        }
    }

}
