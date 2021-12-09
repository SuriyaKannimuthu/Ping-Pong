using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class Bot : MonoBehaviour
{
    [SerializeField]
    private GameObject ball;


    void Update()
    {
        transform.localPosition = new Vector3(ball.transform.position.x , 0, 8);
    }

}


