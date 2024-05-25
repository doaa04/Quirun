using UnityEngine;

public class PlayerCollision : MonoBehaviour 
{

    public PlayerMvt movement;

    void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
