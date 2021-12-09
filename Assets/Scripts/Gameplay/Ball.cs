using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    Vector3 initialImpulse;

    int[] directions = new int[4];
    
    Rigidbody ball_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        directions[0] = 4;
        directions[1] = -4;
        directions[2] = 10;
        directions[3] = -10;

        initialImpulse.x = directions[Random.Range(0, 2)]; 
        initialImpulse.z = directions[Random.Range(2, 4)]; 

        ball_rigidbody = this.gameObject.GetComponent<Rigidbody>();

        ball_rigidbody.AddForce(initialImpulse, ForceMode.Impulse); //For Initial ball moving force.
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            ball_rigidbody.AddForce(ball_rigidbody.velocity * 10 * Time.deltaTime, ForceMode.Impulse); 
        }
        else {
            ball_rigidbody.AddForce(ball_rigidbody.velocity * 5 * Time.deltaTime , ForceMode.Impulse);
        }
    }

}
