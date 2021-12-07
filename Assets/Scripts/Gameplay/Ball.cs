using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField]
    Vector3 initialImpulse;


    Rigidbody ball_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        ball_rigidbody = this.gameObject.GetComponent<Rigidbody>();

        ball_rigidbody.AddForce(initialImpulse, ForceMode.Impulse); //For Initial ball moving force.
    }


    // Update is called once per frame
    void Update()
    {
        
    }

}
