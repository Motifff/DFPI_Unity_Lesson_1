using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathUtils
{
    // Start is called before the first frame update
    public static float GetSphereVolumes(float R)
    {
        return 4f / 3f * Mathf.PI * R * R * R;
    }

    public static float GetMass(float D, float M)
    {
        return D * M;
    }
}
