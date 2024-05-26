using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        transform.position = player.position + offset;
    }
}
