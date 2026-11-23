using UnityEngine;

public class OmniAttributes : MonoBehaviour
{
    //Damage Related
    public float hp = 5;
    public float maxHp = 5;
    public int iFrames = 0;

    //Modifiers
    public float speedMod = 1f;
    public float jumpMod = 1f;
    public float dmgResistMod = 1f;
    public float dmgDealMod = 1f;
    
    //Update Effects
    public float hpRegen = 0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        gainHp(hpRegen);
    }

    public virtual void gainHp(float heal){
        hp += heal;
        if (hp >= maxHp) hp = maxHp;
        if (hp <= 0){ 
            hp = 0;
            die();
        }
    }

    public virtual void OnCollisionEnter(Collision collision){
        collisionLogic(collision);
    }

    //Handles the logic of collisions
    public virtual void collisionLogic(Collision collision){
        
    }

    public virtual void die(){
        
    }
}
