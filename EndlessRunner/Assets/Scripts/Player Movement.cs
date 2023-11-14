using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float walkspeed = 1.5f;  
    public float jumpforce = 5; 
    public bool IsOnGround=true;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRB;


    // Start is called before the first frame update
    void Start()
    {
        playerRB=GetComponent<Rigidbody>();
           
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right*Time.deltaTime*horizontalInput*walkspeed);
        transform.Translate(Vector3.forward*Time.deltaTime*forwardInput*walkspeed);

        if (Input.GetKeyDown(KeyCode.Space)&&IsOnGround)
        {
            playerRB.AddForce(Vector3.up*jumpforce,ForceMode.Impulse);

            IsOnGround=false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        IsOnGround=true;
    }
}
