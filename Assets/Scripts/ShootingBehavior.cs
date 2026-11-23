
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingBehavior : MonoBehaviour
{
    public GameObject weapon;
    public Animator weaponAnim;
    public GameObject player;
    public PlayerInput playerInput;
    public GameObject splatter;
    public GameObject[] weaponList;
    public int weaponValue = 0;

    void Start(){
        weaponAnim = gameObject.GetComponent<Animator>();
        player = transform.parent.transform.parent.gameObject;
        playerInput = player.GetComponent<PlayerInput>();
    }

    public void Shoot(){
        //Debug.Log("pew");
        weaponAnim.SetTrigger("Attack");
    }

    public float chargeSpeed = 100f;
    public int chargeFrames = 60;

    public void Shoot2(){
        //FirstPersonController move = player.GetComponent<FirstPersonController>();
        Debug.Log(transform.parent.transform.forward);
        player.GetComponent<StarterAssets.FirstPersonController>().dash(transform.parent.transform.forward, chargeSpeed, chargeFrames);
    }

    public void OnFire()
    {
        Shoot();
    }

    public void OnAltFire()
    {
        Shoot2();
    }

    public void OnWeaponSwitchWheel(InputValue value){
        if (value.Get() != null){
            //Debug.Log(value.Get());
            if (weaponValue != 1){
                weaponList[1].SetActive(true);
                weaponList[0].SetActive(false);
                weaponValue++;
            } else {
                weaponList[0].SetActive(true);
                weaponList[1].SetActive(false);
                weaponValue = 0;
            }
        }
    }

    public void activateCollider(){
        gameObject.GetComponent<Collider>().enabled = true;
    }

    public void deactivateCollider(){
        gameObject.GetComponent<Collider>().enabled = false;
    }

    public virtual void OnCollisionEnter(Collision collision){
        collisionLogic(collision);
    }

    public virtual void collisionLogic(Collision collision){
        //Take damage when contacting the sword
        if (collision.gameObject.CompareTag("Enemy")){
            DamageManager.Instance.dealDamage(gameObject, collision.gameObject);
            Instantiate(splatter, new Vector3 (collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
        }
    }
    
}
