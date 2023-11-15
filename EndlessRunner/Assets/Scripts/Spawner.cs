using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class lukaskeller : MonoBehaviour
{
    public GameObject cubespawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            //Instantiate(cubespawn,transform.position,Quaternion.identity);
            Instantiate(cubespawn, new Vector3(10f,0f,0f),Quaternion.identity);

        }
    }
}
