using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    public PlayerMovement movement;
    ///public Rigidbody rb;
    //public float explosionforce = 100f ;
    ///public float explosionradius = 100f;
    ///public float upwardsmodifier = 100f;
    ///public Vector3 explosionoffset;


    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            ///rb.AddExplosionForce(explosionforce, rb.position, explosionradius, upwardsmodifier, ForceMode.VelocityChange);
            FindObjectOfType<GameManager>().EndGame();

        }
    }

}