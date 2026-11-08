
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingBehavior : MonoBehaviour
{
    public GameObject weapon;
    public Animator weaponAnim;

    void Start(){
        weaponAnim = weapon.GetComponent<Animator>();
    }

    public void Shoot(){
        Debug.Log("pew");
        weaponAnim.SetTrigger("Attack");
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
