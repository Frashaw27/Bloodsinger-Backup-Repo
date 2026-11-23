using UnityEngine;

public class DamageManager : MonoBehaviour
{

    public static DamageManager Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void dealDamage(GameObject hitter, GameObject hittee){
        //Debug.Log(hittee);
        float baseDamage = hitter.gameObject.GetComponent<DamageStats>().damage;
        EnemyBehavior stats = hittee.gameObject.GetComponent<EnemyBehavior>();
        float damage = baseDamage * 1f;
        damage *= stats.dmgResistMod;
        if (damage < 0) damage = 0; 
        stats.gainHp(-damage);
    }
}
