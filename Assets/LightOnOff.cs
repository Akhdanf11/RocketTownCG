using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        myLight.enabled = !myLight.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("l")){
            myLight.enabled = !myLight.enabled;
        }
    }
}
