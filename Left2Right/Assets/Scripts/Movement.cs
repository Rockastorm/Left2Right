using UnityEngine;
using UnityEngine.InputSystem;
using System;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{

    // Variables
    public float Speed;

    private Vector3 position;

    public InputActionReference movement;

    // Update is called once per frame
    void Update()
    {

        position = movement.action.ReadValue<Vector2>() * Speed * Time.deltaTime;

        transform.position += position;

    }
}
