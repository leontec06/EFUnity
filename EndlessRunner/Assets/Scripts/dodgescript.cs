using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
AudioSource aud;


    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && GameObject.Find("Player").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("run") &&GameObject.Find("Player").GetComponent<Transform>().position.x<4.5|| Input.GetKeyDown(KeyCode.LeftArrow)&& GameObject.Find("Player").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("run")&&GameObject.Find("Player").GetComponent<Transform>().position.x>-4.5){
            aud.Play();
        }
    }
}
