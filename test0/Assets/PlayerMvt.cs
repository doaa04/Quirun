using UnityEngine;

public class PlayerMvt : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 4000f;

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
            rb.AddForce(sideForce * Time.deltaTime, 0, 0); // force on x axis  
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0); // force on x axis  
        }
    }
}
