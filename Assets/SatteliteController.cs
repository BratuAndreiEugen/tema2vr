using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatteliteController : MonoBehaviour
{
    
    public float rotationSpeed = 50f; // Speed of rotation in degrees per second
    public float radius = 3000f; // Radius of the circular motion

    private float angle = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the position based on the angle and radius
        float x = Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
        float z = Mathf.Sin(angle * Mathf.Deg2Rad) * radius;

        // Set the object's position
        transform.position = new Vector3(x, transform.position.y, z);

        // Increment the angle based on the rotation speed
        angle += rotationSpeed * Time.deltaTime;

        // Wrap the angle to keep it within a reasonable range
        if (angle > 360f)
        {
            angle -= 360f;
        }
    }
}
