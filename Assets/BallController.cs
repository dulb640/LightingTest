using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{
    public Rigidbody body;
    public float strength = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(InputAction.CallbackContext context) {
        var value = context.ReadValue<Vector2>();
        body.AddForce(new Vector3(value.x, 0, value.y)*strength);
    }
}
