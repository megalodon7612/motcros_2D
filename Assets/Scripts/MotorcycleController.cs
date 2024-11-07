using UnityEngine;

public class MotorcycleController : MonoBehaviour
{
    [SerializeField] private float acceleration = 1000;
    [SerializeField] private float rotationPower = 300;
    [SerializeField] private Rigidbody2D motorcyclRb;
    [SerializeField] private WheelJoint2D frontWheel;
    [SerializeField] private WheelJoint2D backWheele;

    private JointMotor2D motor;

    private void Awake()
    {
        motor = backWheele.motor;
    }
    private void Update()
    {
        if (PlayerImput.Brake == true)
        {

        }
        else if (PlayerImput.Horizontal != 0)
        {

        }
        else 
        {

        }

        if (PlayerImput.Vertical != 0)
        {

        }
    }

    private void Brake(WheelJoint2D wheel)
    {

    }
}
