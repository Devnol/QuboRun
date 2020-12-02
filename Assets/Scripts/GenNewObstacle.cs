//Generates new obstacles at a random offset from the X axis center every genInterval units of distance at the end of the platform
using UnityEngine;

public class GenNewObstacle : MonoBehaviour
{
// Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject Obstacle;
    public Transform GeneratorTf;

    public float genInterval = 5;

    float prevPos;

    void Start() 
    {
        prevPos = GeneratorTf.position.z;
    }

    // Update is called once per frame
    void Update()
    {   
        if (GeneratorTf.position.z >  prevPos + genInterval) {
            prevPos = GeneratorTf.position.z;
            Instantiate(Obstacle, new Vector3(Random.Range(-7.5f, 7.5f), 1, GeneratorTf.position.z), Quaternion.identity);
        }
    }

}
