using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_moon : MonoBehaviour
{
    public Transform earth;
    public Transform moon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moon.RotateAround(earth.position, Vector3.up, 100 * Time.deltaTime);
    }
}
