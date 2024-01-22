using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BlendingController : MonoBehaviour
{
    private GGJ2024 inputActions = null;

    private float mouthBlendValue;
    private float eyeBlendValue;
    private float faceBlendValue;

    [SerializeField] private float mouthBlendValueSpeed;
    [SerializeField] private float eyeBlendValueSpeed;
    [SerializeField] private float faceBlendValueSpeed;

    private void Awake()
    {
        inputActions = new GGJ2024();
    }

    private void Update()
    {
        if (mouthBlendValue > 0)
            mouthBlendValue += Time.deltaTime * mouthBlendValueSpeed;
        else
            mouthBlendValue = 0;

        if (eyeBlendValue > 0)
            eyeBlendValue += Time.deltaTime * eyeBlendValueSpeed;
        else
            eyeBlendValue = 0;

        if (faceBlendValue > 0)
            faceBlendValue += Time.deltaTime * faceBlendValueSpeed;
        else
            faceBlendValue = 0;
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
        mouthBlendValue += Time.deltaTime * mouthBlendValueSpeed;
        //assign value to blend shape
    }
}
