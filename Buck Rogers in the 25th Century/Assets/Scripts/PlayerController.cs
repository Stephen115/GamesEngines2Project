using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerControls playerActionControls;
    public Transform Forward;
    public Transform Left;
    public Transform Right;
    public Transform Up;
    public Transform Down;


    private void Awake()
    {
        playerActionControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerActionControls.PlayerFlight.Enable();
        playerActionControls.PlayerFlight.Move.performed += OnMovePerformed;
        playerActionControls.PlayerFlight.Rotate.performed += OnRotatePerformed;
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        if (moveInput.x > 0)
        {
            this.GetComponent<BigBoid>().seekTargetTransform = Forward;
        } else if (moveInput.x < 0) {
            Debug.Log("Reverse");
        }
        else {
            this.GetComponent<BigBoid>().seekTargetTransform = null;
        }
        Debug.Log($"Move Input: {moveInput}");
    }
    private void OnRotatePerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        if (moveInput.x > 0)
        {
            this.GetComponent<BigBoid>().seekTargetTransform = Down;
        }
        else if (moveInput.x < 0)
        {
            this.GetComponent<BigBoid>().seekTargetTransform = Up;
        }
        else if (moveInput.y < 0)
        {
            this.GetComponent<BigBoid>().seekTargetTransform = Right;
        }
        else if (moveInput.y < 0)
        {
            this.GetComponent<BigBoid>().seekTargetTransform = Left;
        }
        else
        {
            this.GetComponent<BigBoid>().seekTargetTransform = null;
        }
        Debug.Log($"Move Input: {moveInput}");
    }
    private void OnShootPerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
    private void OnMissilePerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
    private void OnBoostPerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
    private void OnChangeCameraPerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
    private void OnLockTargetPerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
    private void OnZoomCameraPerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
    private void OnSpecialPerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
    private void OnMenuPerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
}
