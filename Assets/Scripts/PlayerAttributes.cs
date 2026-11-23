using UnityEngine;

public class PlayerAttributes : OmniAttributes
{
    public float bloodAmount = 100f;
    public float bloodMax = 100f;
    public bool defyGravity = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void gainHp(float heal){
        base.gainHp(heal);
        //Debug.Log("healed");
    }

     public void OnCollisionEnter(Collision collision){
        collisionLogic(collision);
    }

    public virtual void collisionLogic(Collision collision){
        //Take damage when contacting the sword
        if (collision.gameObject.CompareTag("Enemy")){
            Debug.Log("hit");
            gainHp(-1);
        }
    }

    public void OnParticleTrigger(){
        Debug.Log("hh");
    }

    public override void die(){
        Debug.Log("you died");
    }
}
