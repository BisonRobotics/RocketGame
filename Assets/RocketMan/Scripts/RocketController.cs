using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ps = UnityEngine.ParticleSystem;

public class RocketController : MonoBehaviour {

    float startEmission = 0;

    [SerializeField]
    ParticleSystem particles;

    ps.EmissionModule emmod;

    Rigidbody rb;

    [SerializeField]
    float pitchSensitivity;

    [SerializeField]
    float thrustUp;

    // Use this for initialization
    void Start () {
        startEmission = particles.emission.rateOverTime.constant;
        emmod = particles.emission;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {

    }

    // Update called in the physics update (50 times persecond)
    void FixedUpdate () {
		
        if (Input.GetKey(KeyCode.W))
        {
            emmod.rateOverTimeMultiplier = startEmission;
            rb.AddRelativeForce(0, thrustUp, 0);
        }
        else
        {
            emmod.rateOverTimeMultiplier = 0;
        }

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeTorque(0, 0, pitchSensitivity);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeTorque(0, 0, -pitchSensitivity);
        }
    }
}
