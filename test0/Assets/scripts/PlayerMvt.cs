using UnityEngine;

public class PlayerMvt : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 4000f;
    public float sidewayForce = 100f;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void FixedUpdate() {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // force on z axis  

        if (Input.GetKey("d")) {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // force on x axis  
        }
        if (Input.GetKey("a")) {
            rb.AddForce(- sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // force on x axis  
        }
        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
