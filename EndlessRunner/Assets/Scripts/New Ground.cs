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
    public GameObject Obstacle1;
    public GameObject Obstacle2;
    public GameObject Obstacle3;
    public GameObject Coin;
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
                float randomNumber = Random.Range(1, 4);

                
                if (randomNumber==1){Instantiate(Obstacle1, new Vector3(0f,0f,60f*levelnumber+120), Quaternion.identity);}
                if (randomNumber==2){Instantiate(Obstacle2, new Vector3(0f,0f,60f*levelnumber+120), Quaternion.identity);}
                if (randomNumber==3){Instantiate(Obstacle3, new Vector3(0f,0f,60f*levelnumber+120), Quaternion.identity);}

                float randomNumber1 = Random.Range(-1, 2);
                float randomNumber2 = Random.Range(-1, 2);
            
                //Instantiate(Coin, new Vector3(randomNumber1*5f, randomNumber2*5f, 60f*levelnumber+90),Quaternion.identity);
                //Instantiate(Coin, new Vector3(0f, 3f, 60f*levelnumber+90),Quaternion.identity);
                Coin.SetActive(true);
                Instantiate(Coin, new Vector3(randomNumber1*5f, 3f, 60f * levelnumber + 90), Quaternion.Euler(90f, 180f, 0f));
                


                Instantiate(newGround, new Vector3(0f,0f,60f*levelnumber+120), Quaternion.identity);                
                transform.Translate(new Vector3(0f,0f,60f));


                Instantiate(water, new Vector3(0f,-23f,60f*levelnumber+120), Quaternion.identity); 
                
                levelnumber+=1;
                //print(levelnumber);
            }
        }
}   
