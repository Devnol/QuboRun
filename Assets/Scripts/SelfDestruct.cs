//Kills Obstacle once it's out of the Player's view in order to preserve memory
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public Transform PlayerTf;
    public Transform ObstacleTf;
    void Start()
    {
       PlayerTf = GameObject.Find("Player").GetComponent<Transform>();
       ObstacleTf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ObstacleTf.position.z < PlayerTf.position.z - 10)
        {
            Destroy(gameObject);
        }
    }
}
