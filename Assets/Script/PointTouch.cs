using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTouch : MonoBehaviour
{
    public GameObject particles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy() 
    {
        Vector3 actualPos = new Vector3(transform.position.x, transform.position.y, transform.position.z); 
        Instantiate(particles, actualPos, particles.transform.rotation);
        Debug.Log("Particles");
    }
}
