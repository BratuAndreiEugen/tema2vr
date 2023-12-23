using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrebuchetController : MonoBehaviour
{
    public Rigidbody weight;
    public GameObject projectile;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // release the weight

            weight.isKinematic = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            // launch projectile
            HingeJoint hingeToDestroy;
            hingeToDestroy = projectile.GetComponent<HingeJoint>();
            
            Destroy(hingeToDestroy);
        }
    }
}
