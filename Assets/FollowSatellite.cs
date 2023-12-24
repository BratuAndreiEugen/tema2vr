using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSatellite : MonoBehaviour
{

    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            // Make this object look at the target's position
            transform.LookAt(target.position);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

        }
    }
}
