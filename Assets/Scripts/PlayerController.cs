using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _vehicleSpeed = 25f;
    private float _turnSpeed = 50f;
    private float _horizontalInput;
    private float _verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Getting inputs
        GetHorizontalInput();
        GetVerticalInput();

        //Move the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * _vehicleSpeed * _verticalInput);

        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * _turnSpeed * _horizontalInput);
    }

    void GetHorizontalInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    void GetVerticalInput()
    {
        _verticalInput = Input.GetAxis("Vertical");
    }
}
