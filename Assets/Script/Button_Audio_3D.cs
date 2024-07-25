using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Audio_3D : MonoBehaviour
{
    public GameObject Circle;
    public float Distance;
    private Number_Audio Number_Audio;
    public AudioClip sound1;
    AudioSource audioSource;
    public bool isPushed;
    private float prev_position_z;
    // Start is called before the first frame update
    void Start()
    {
        //prev_position_z = 0.0000f;
        isPushed = false;
        audioSource = GetComponent<AudioSource>();
        //Distance = 0.0f;
        Number_Audio = this.GetComponent<Number_Audio>();
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Circle.transform.position.z+Distance-0.023f;
        if(isPushed){
            if( dis>=-0.023f){
                audioSource.PlayOneShot(sound1);
                isPushed = false;
            }
        } 
        //prev_position_z = Circle.transform.position.z;
    }
}
