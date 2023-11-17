using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class NewGround : MonoBehaviour
{
    public GameObject newGround;
    public GameObject water;
    private int levelnumber=1;
    // Start is called before the first frame update

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
        {
            
            if (other.gameObject.tag == "Player")
            {
                Instantiate(newGround, new Vector3(0f,0f,60f*levelnumber+120), Quaternion.identity);                
                transform.Translate(new Vector3(0f,0f,60f));

                Instantiate(water, new Vector3(0f,-23f,60f*levelnumber+120), Quaternion.identity); 
                
                levelnumber+=1;
                print(levelnumber);
            }
        }
}   
