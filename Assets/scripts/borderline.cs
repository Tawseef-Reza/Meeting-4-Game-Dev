using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class borderline : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = new Vector3(48.8f, 14.3f, 12.2f);
    }
}
