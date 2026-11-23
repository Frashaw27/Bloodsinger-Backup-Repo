using UnityEngine;

public class BloodParticleBehavior : MonoBehaviour
{
    //public GameObject player;
    public int killFrames = 60;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];
        transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        killFrames--;
        if (killFrames == 0){
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other){
        collisionLogic(other);
    }

    //Handles the logic of collisions
    public virtual void collisionLogic(Collider collision){
        if (collision.gameObject.CompareTag("Player")){
            //Debug.Log("hh");
            collision.GetComponent<PlayerAttributes>().bloodAmount += 10f;
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
