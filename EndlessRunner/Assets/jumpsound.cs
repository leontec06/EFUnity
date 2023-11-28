using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpsound : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource aud;

    public bool IsOnGround;

    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            aud.Play();
        }


        
        
    }
}
