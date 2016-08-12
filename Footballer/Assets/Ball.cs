using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public float thrust = 0.1f;
    public float torque = 0.1f;
    public float fixedVelocityY = -0.1f;

    void FixedUpdate()
    {
        var rb = GetComponent<Rigidbody>();
        //Vector3 counterGravity;
        //counterGravity = new Vector3(0.0f, -Physics.gravity.y, 0.0f);
        //rigibody.AddForce(counterGravity, ForceMode.Acceleration);
        //float forwardThrust = Input.GetAxis("Vertical") * thrust;
        //rb.AddForce(transform.forward * forwardThrust);
        //float turningTorque = Input.GetAxis("Horizontal") * torque;
        //rb.AddTorque(transform.up * turningTorque);
        //rb.velocity = new Vector3(0.0f, fixedVelocityY, 0.0f);
        //rb.
    }
}
