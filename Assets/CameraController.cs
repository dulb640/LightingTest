using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{

    public float sensitivity = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void Look(InputAction.CallbackContext context) {
        var value = context.ReadValue<Vector2>();
        transform.Rotate(-value.y*Time.deltaTime*sensitivity, value.x*Time.deltaTime*sensitivity, 0);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
    }
}
