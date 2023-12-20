using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class transformObject : MonoBehaviour
{
    [SerializeField] private Material Material_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("s")){
            Material_2.color = Color.red;
        }
        if(Input.GetKeyDown("n")){
           Material_2.color = Color.green; 
        }
        if (Input.GetKeyDown("t")){
            transform.localScale = new Vector3(1, Random.Range(1, 3), 2);
        }
    }
}
