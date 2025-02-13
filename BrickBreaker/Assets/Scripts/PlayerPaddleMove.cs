//Michael Anglemier, following "Bug Free Productions" tutorial

using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : MonoBehaviour
{
    // Vars

    protected Vector3 aMovDir = Vector3.zero;
    [SerializeField, Range(1, 20)] protected float moveSpeed = 1f;
    //[SerializeField, Range(10, 29)] protected float maxSpeed = 25f;

    //Methods

    private void Update()
    {
        MovePaddle();
    }

    //Take Input from action
    public void MoveInput(InputAction.CallbackContext aCon)
    {
        Vector2 av2 = aCon.ReadValue<Vector2>();

        aMovDir.x = av2.x;
        //aMovDir.z = av2.y;
    }

    public void MovePaddle()
    {
        transform.Translate(aMovDir * moveSpeed * Time.deltaTime );
    }

    //Accessors
}
