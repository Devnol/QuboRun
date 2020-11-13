using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody PlayerRb;
    public Transform PlayerTf;
    public Transform GroundTf;
    public float ForwardForce = 2000f;
    public float SidewaysForce = 500f;
    public float groundOffsetZ = 45;
    // FixedUpdate is called once per frame, better than Update for physics calculations
    void FixedUpdate()
    {
        PlayerRb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("a"))
        {
            PlayerRb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if (Input.GetKey("d"))
        {
            PlayerRb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

    void Update()
    {
        if (PlayerTf.position.y < 0) {
            FindObjectOfType<GameManager>().Die();
        }
        GroundTf.position = new Vector3 (0, 0, PlayerTf.position.z + groundOffsetZ);
    }
}
