using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerMovement : MonoBehaviour
{
 
    public float walkspeed = 4f;  
    public float jumpforce = 5; 
    public bool IsOnGround=true;
    //private float lanewidth=5;
    private Rigidbody playerRB;
    public int PlayerScore=0;
    Animator animPlayer;

    

    


    // Start is called before the first frame update
    void Start()
    {
        PlayerScore=0;
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
        if (Input.GetKeyDown(KeyCode.LeftArrow) && animPlayer.GetCurrentAnimatorStateInfo(0).IsName("run") && IsOnGround == true&&transform.position.x>-4)
        {
            //transform.Translate(Vector3.left*lanewidth);
            animPlayer.SetTrigger("left");
            playerRB.AddForce(new Vector3(-10.97f, 0, 0),ForceMode.Impulse);
        }
       
        if (Input.GetKeyDown(KeyCode.RightArrow)&&animPlayer.GetCurrentAnimatorStateInfo(0).IsName("run")&&IsOnGround == true&&transform.position.x<4)
        {
            animPlayer.SetTrigger("right");
            //transform.Translate(Vector3.right*lanewidth);
            playerRB.AddForce(new Vector3(10.97f, 0, 0),ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space)&&IsOnGround&&animPlayer.GetCurrentAnimatorStateInfo(0).IsName("run"))
        {
            playerRB.velocity=Vector3.zero;
            playerRB.angularVelocity=Vector3.zero;
            animPlayer.SetTrigger("jump");
            playerRB.AddForce(Vector3.up*jumpforce,ForceMode.Impulse);
            IsOnGround=false;
           
            
        }

        //if (animPlayer.GetCurrentAnimatorStateInfo(0).IsName("exitscreen")){
          //  SceneManager.LoadScene("Game Over");
        //}

    }

    async void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Ground")
        {
            IsOnGround=true;
            
        }
        if (collision.gameObject.tag =="Obstacle")
        {
            walkspeed=0f;
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled=false;
            animPlayer.SetTrigger("die");
            Debug.Log("died");
        }
            
        if (collision.gameObject.tag=="Coin")
        {
            Debug.Log("collision");
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            PlayerScore = PlayerScore+1;
            //PlayerScore=+1;
        }
            //WaitNarration();

            


        }
        
    }


    



