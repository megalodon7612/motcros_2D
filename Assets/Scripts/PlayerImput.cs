using UnityEngine;

public class PlayerImput : MonoBehaviour
{
    public static float Horizontal;
    public static float Vertical;
    public static bool Brake;

    private void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        Brake = Input.GetButton("Jump");
    }
}
