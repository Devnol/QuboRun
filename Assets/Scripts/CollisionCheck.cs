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
