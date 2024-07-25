using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 左に移動
        // if (Input.GetKey (KeyCode.LeftArrow)) {
        //     this.transform.Translate (-0.0001f,0.0f,0.0f);
        // }
        // 右に移動
        // if (Input.GetKey (KeyCode.RightArrow)) {
        //     this.transform.Translate (0.0001f,0.0f,0.0f);
        // }
        // 前に移動
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            this.transform.Translate (0.0f,0.0f,0.001f);
        }
        // 後ろに移動
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            this.transform.Translate (0.0f,0.0f,-0.001f);
        }
    }
}

