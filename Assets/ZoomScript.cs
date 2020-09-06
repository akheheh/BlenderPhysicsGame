using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0f) {
            Camera.main.fieldOfView--;
        } else if(Input.GetAxis("Mouse ScrollWheel") < 0f) {
            Camera.main.fieldOfView++;
        }
    }
}
