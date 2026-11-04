
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingBehavior : MonoBehaviour
{
    public void Shoot(){
        Debug.Log("pew");
    }

    public void OnFire()
    {
        Shoot();
    }

    public void OnAltFire()
    {
        Debug.Log("pew but no");
    }
    
}
