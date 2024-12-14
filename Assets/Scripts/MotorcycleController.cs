using UnityEngine;

public class MotorcycleController : MonoBehaviour
{
    [SerializeField] private float _acceleration = 1000;
    [SerializeField] private float _rotationPower = 300;
    [SerializeField] private Rigidbody2D _motorcyclRb;
    [SerializeField] private WheelJoint2D _frontWheel;
    [SerializeField] private WheelJoint2D _backWheel;

    private JointMotor2D _motor;

    private void Awake()
    {
        _motor = _backWheel.motor;
    }
    private void FixedUpdate()
    {

        if (PlayerImput.Brake == true)
        {
            Brake(_backWheel);
            Brake(_frontWheel);
        }
        else if (PlayerImput.Horizontal != 0)
        {
            
            if (_frontWheel != null)
                _frontWheel.useMotor = false;

            if (_backWheel != null)
            {
                _backWheel.useMotor = true;
                float _direction = PlayerImput.Horizontal;
                float _speed = _acceleration * _direction * -1;

                _motor.motorSpeed = _backWheel.jointSpeed;
                _motor.motorSpeed += _speed * Time.fixedDeltaTime;

                _backWheel.motor = _motor;
            }
        }
        else 
        {
            if (_backWheel != null)
                _backWheel.useMotor = false;

            if (_frontWheel != null)
                _frontWheel.useMotor = false;
        }

        if (PlayerImput.Vertical != 0)
        {
            float _vertical = PlayerImput.Vertical;

            _motorcyclRb.MoveRotation(_motorcyclRb.rotation += _vertical * _rotationPower * Time.fixedDeltaTime);
        }
    }

    private void Brake(WheelJoint2D wheel)
    {
        if (wheel == null)
            return;

        wheel.useMotor = true;

        _motor.motorSpeed = 0;

        wheel.motor = _motor;
    }
}
