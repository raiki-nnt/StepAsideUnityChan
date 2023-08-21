using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    
    //Main Cameraのオブジェクト
    private GameObject MainCamera;
    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        //Maincameraのオブジェクトを取得
        this.MainCamera = GameObject.Find ("Main Camera"); 
        
        if(this.transform.position.z < MainCamera.transform.position.z)
        {
            Destroy(gameObject);
        }

    }
}
