using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsound : MonoBehaviour
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
        
        
    }

    async void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            aud.Play();
            
        }

        }
}
