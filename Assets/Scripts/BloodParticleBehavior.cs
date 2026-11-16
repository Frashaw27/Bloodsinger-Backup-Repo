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
}
