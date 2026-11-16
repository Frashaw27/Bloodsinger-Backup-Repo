
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingBehavior : MonoBehaviour
{
    public GameObject weapon;
    public Animator weaponAnim;
    public GameObject player;

    void Start(){
        weaponAnim = gameObject.GetComponent<Animator>();
        player = transform.parent.gameObject;
    }

    public void Shoot(){
        //Debug.Log("pew");
        weaponAnim.SetTrigger("Attack");
    }

    public void Shoot2(){
        //FirstPersonController move = player.GetComponent<FirstPersonController>();
        //Debug.Log(move.isDashing);
    }

    public void OnFire()
    {
        Shoot();
    }

    public void OnAltFire()
    {
        Shoot2();
    }

    public void activateCollider(){
        gameObject.GetComponent<Collider>().enabled = true;
    }

    public void deactivateCollider(){
        gameObject.GetComponent<Collider>().enabled = false;
    }
    
}
