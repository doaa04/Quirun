using Unity.VisualScripting;
using UnityEngine;

public class PlayerMvt : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 4000f;
    public float sidewayForce = 100f;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
