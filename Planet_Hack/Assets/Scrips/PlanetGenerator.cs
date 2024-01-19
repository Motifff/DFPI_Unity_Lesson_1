using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGenerator : MonoBehaviour
{
    public GameObject prefab;
    public BoxCollider bounds;

    [Range(0, 100)]
    public float minRadius;

    [Range(0, 100)]
    public float maxRadius;

    [Range(0, 100)]
    public float minDensity;

    [Range(0, 100)]
    public float maxDensity;

    [Range(-50, 50)]  public float minVelosity;
    [Range(-50, 50)]  public float maxVelosity;

    public List<Planet> planets;

    // Start is called before the first frame update
    void Start()
    {
        planets = new List<Planet>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateRandomPlanets();
        }
    }

    public void GenerateRandomPlanets()
    {
        if (prefab == null)
        {
            return;
        }

        var min = bounds.bounds.min;
        var max = bounds.bounds.max;

        var x = Random.Range(min.x, max.x);
        var y = Random.Range(min.y, max.y);
        var z = Random.Range(min.z, max.z);

        var r = Random.Range(minRadius,maxRadius);
        var d = Random.Range(minDensity,maxDensity);

        var go = Instantiate(prefab, new Vector3(x,y,z), Quaternion.identity, transform);

        var planet = go.GetComponent<Planet>();

        planet.radius = r;
        planet.density = d;

        planet.initialVelocity = new Vector3(
            Random.Range(minVelosity, maxVelosity),
            Random.Range(minVelosity, maxVelosity),
            Random.Range(minVelosity, maxVelosity)
        ) ;
    }
}
