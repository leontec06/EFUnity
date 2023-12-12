using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correctPosition : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animPlayer;

    void Start()

    {
        animPlayer=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x>4.8&&transform.position.x<5.2&& animPlayer.GetCurrentAnimatorStateInfo(0).IsName("run")){
            
            transform.position = new Vector3(5f, transform.position.y, transform.position.z);
        }

        if (transform.position.x>-0.2&&transform.position.x<0.2&& animPlayer.GetCurrentAnimatorStateInfo(0).IsName("run")){
            
            // Setze die X-Position auf 0
            transform.position = new Vector3(0f, transform.position.y, transform.position.z);

        }

        if (transform.position.x>-5.2&&transform.position.x<-4.8&& animPlayer.GetCurrentAnimatorStateInfo(0).IsName("run")){
            
            transform.position = new Vector3(-5f, transform.position.y, transform.position.z);        }
    }
}
