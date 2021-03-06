using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerControls playerActionControls;

    private void Awake()
    {
        playerActionControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerActionControls.PlayerFlight.Enable();
        playerActionControls.PlayerFlight.Move.performed += OnMovePerformed;
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
}
