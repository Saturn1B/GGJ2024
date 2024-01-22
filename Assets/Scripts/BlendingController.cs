using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BlendingController : MonoBehaviour
{
    [SerializeField] private GGJ2024 inputActions = null;

    private void Awake()
    {
        inputActions = new GGJ2024();
    }

    private void OnEnable()
    {
        inputActions.Enable();
        inputActions.Player.Mouth.performed += OnChangeMouthValue;
    }

    private void OnDisable()
    {
        inputActions.Disable();
        inputActions.Player.Mouth.performed -= OnChangeMouthValue;
    }

    private void OnChangeMouthValue(InputAction.CallbackContext value)
    {
        Debug.Log("press a");
    }
}
