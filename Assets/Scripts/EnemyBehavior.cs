using UnityEngine;

public class EnemyBehavior : OmniAttributes
{
    public GameObject splatter;
    public AudioClip hitSound;
    //public GameObject particle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //particle = gameObject.GetComponent<>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void collisionLogic(Collision collision){
        //Take damage when contacting the sword
        //Instantiate(gameObject, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        //if (collision.gameObject.CompareTag("Weapon")){
            //Debug.Log("hit");
            //gainHp(-1);
            //AudioManager.Instance.PlaySoundEffect(hitSound, 1f);
        //}
    }

    public override void die(){
        Instantiate(splatter, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        Destroy(gameObject);
    }
}
