using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float walkspeed = 4f;  
    public float jumpforce = 5; 
    public bool IsOnGround=true;
    private float lanewidth=5;
    private Rigidbody playerRB;

    Animator animPlayer;


    // Start is called before the first frame update
    void Start()
    {
        playerRB=GetComponent<Rigidbody>();
        animPlayer=GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.forward*Time.deltaTime*walkspeed);
        //horizontalInput = Input.GetAxis("Horizontal");

        //forwardInput = Input.GetAxis("Vertical");
        if (IsOnGround==true){
            animPlayer.SetTrigger("land");
        }
        //transform.Translate(Vector3.right*Time.deltaTime*horizontalInput*walkspeed);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left*lanewidth);
        }
       
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right*lanewidth);
        }

        if (Input.GetKeyDown(KeyCode.Space)&&IsOnGround)
        {
            animPlayer.SetTrigger("jump");
            playerRB.AddForce(Vector3.up*jumpforce,ForceMode.Impulse);
            IsOnGround=false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Ground")
        {
            IsOnGround=true;
            
        }
        
    }

    /*void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="SpawnTrigger")
        {
            
        }
    }*/

}

