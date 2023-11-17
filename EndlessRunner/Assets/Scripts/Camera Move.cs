using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 4.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newZ = transform.position.z + Time.deltaTime * moveSpeed;

    // Aktualisiere die Position des GameObjects
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
    }
}
