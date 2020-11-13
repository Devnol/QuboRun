using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform PlayerTf;
    public Transform CameraTf;
    public Vector3 offsets;
    // Update is called once per frame
    void Update()
    {
        CameraTf.position = PlayerTf.position + offsets;
    }
}