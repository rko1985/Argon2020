using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xThrow = Input.GetAxis("Horizontal");       
        float yThrow = Input.GetAxis("Vertical");

        float xOffset = .1f;
        float newXPos = transform.localPosition.x + xOffset;

        transform.localPosition = new Vector3(newXPos, transform.localPosition.y, transform.localPosition.z);
        
    }
}
