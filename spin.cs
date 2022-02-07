using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    //[SerializeField] private Vector3 _rotation; 
    //[SerializeField] private float _speed; 
    }

    // Update is called once per frame
    void Update()
    {
        
        //Time.deltaTime is the 
        //transform.Rotate(80 * Time.deltaTime, 80 * Time.deltaTime,0f,Space.Self);
        transform.Rotate(0f,0f,50 * Time.deltaTime,Space.Self );
        //transform.Rotate(0f,80 * Time.deltaTime,0f,Space.Self );
        //transform.Rotate(80 * Time.deltaTime,0f,0f,Space.Self );
    }
}
