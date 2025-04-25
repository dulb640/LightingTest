using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float sensitivity = 10;
    public float speed = 1;
    
    public Transform cam;
    public Rigidbody body;
    
    private InputAction moveAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // FixedUpdate is called once per physics frame
    void FixedUpdate()
    {
        var value = moveAction.ReadValue<Vector2>();
        body.AddForce(new Vector3(value.x, 0, value.y) * speed);
    }

    public void Look(InputAction.CallbackContext context)
    {
        var value = context.ReadValue<Vector2>();
        var newLookX = cam.localEulerAngles.x - value.y * Time.deltaTime * sensitivity;
        if (newLookX > 89 && newLookX <= 180) newLookX = 89f;
        if (newLookX < -89 && newLookX >= -180) newLookX = -89f;
        cam.localEulerAngles = new Vector3(newLookX, 0, 0);
        transform.Rotate(0, value.x * Time.deltaTime * sensitivity, 0);
    }
    
    public void Move(InputAction.CallbackContext context)
    {
    }
}