using UnityEngine;
using UnityEngine.Events;

public class Rider : MonoBehaviour
{
    public UnityEvent OnCrash;

    public bool IsCrashed => isCrashed;
    
    private bool isCrashed;
}