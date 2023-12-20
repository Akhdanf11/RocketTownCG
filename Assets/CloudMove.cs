using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float speed;
    [SerializeField] private Material myMaterial;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown("s")){
        //     myMaterial.color = new Color32( 102 , 102 , 153 , 255 );
        // }
        // if(Input.GetKeyDown("n")){
        //    myMaterial.color = Color.white; 
        // }
    }
}
