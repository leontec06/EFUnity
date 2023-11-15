using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class NewGround : MonoBehaviour
{
    public GameObject newGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Instantiate(newGround,transform.position,Quaternion.identity);
                print("LoL");
            }
        }
    }
}
