using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveship : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(new Vector3(0, 180, 0));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -5f)*Time.deltaTime);
    }
}
