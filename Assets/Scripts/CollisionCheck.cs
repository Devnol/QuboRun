//Code that checks for collision between the Player and Obstacles, 
//then kills the player if there's one.
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{  
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().Die();
        }
    }
}
