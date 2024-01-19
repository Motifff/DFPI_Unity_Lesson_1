using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [Range(1, 100)]
    public float radius;

    [Range(1, 100)]
    public float density;

    public float Mass {
        get
        {
            return MathUtils.GetMass(density, MathUtils.GetSphereVolumes(radius));
        }
    }

    public Vector3 initialVelocity;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = initialVelocity;

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(radius,radius,radius);
        rb.mass = Mass;
    }
}
