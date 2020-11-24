using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //creating a container(variable) to contain our player speed
    //SerializeField allows us to see private variables in the inspector
    [SerializeField]
    private float _speed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        //Take the current player and we will be changing it to x=0,y=0,z=0
        transform.position = new Vector3(0,0,0); 
    }

    // Update is called once per frame
    void Update()
    {
        //move the player to the right
        //realtime
        //x * realtime(Time.deltaTime) = 1m/s
        //1 * fps e.g 1 * 1500fps (this calculation is used when not multiplying by Time.deltaTime)
        
        //if we press the right arrow move the player to the right
        if(Input.GetKey(KeyCode.RightArrow))
        {
            //move the player to the right
            transform.Translate(_speed * Time.deltaTime,0,0);
        }
    }
}
