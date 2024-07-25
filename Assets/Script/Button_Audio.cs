using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Audio : MonoBehaviour
{
    public GameObject Circle;//座標を取得する円オブジェクト
    public Button One;
    public Button Two;
    public Button Three;
    public Button Four;
    public Button Five;
    public Button Six;
    public Button Seven;
    public Button Eight;
    public Button Nine;
    private float Distance;//結像面より手前の距離
    private Button Push_Button;//押すボタン
    private Number_Audio Number_Audio;
    public AudioClip sound1;
    AudioSource audioSource;
    public bool isPushed;

    private float prev_position_z;

    // Start is called before the first frame update
    void Start()
    {
        prev_position_z = 0.0000f;
        Distance = 0.0f;
        isPushed = false;
        audioSource = GetComponent<AudioSource>();
        Number_Audio = this.GetComponent<Number_Audio>();
    }

    // Update is called once per frame
    void Update()
    {
        float dis = prev_position_z - Circle.transform.position.z;
        if(isPushed){
            if(Circle.transform.position.z >= Distance && dis < 0.0){
                audioSource.PlayOneShot(sound1);
                isPushed = false;
            }
        } 
        prev_position_z = Circle.transform.position.z;
    }

    private void ButtonSelect(int changeState){
        switch(changeState){
            case 1:
                Push_Button = One;
                break;
            case 2:
                Push_Button = Two;
                break;
            case 3:
                Push_Button = Three;
                break;
            case 4:
                Push_Button = Four;
                break;
            case 5:
                Push_Button = Five;
                break;
            case 6:
                Push_Button = Six;
                break;
            case 7:
                Push_Button = Seven;
                break;
            case 8:
                Push_Button = Eight;
                break;
            case 9:
                Push_Button = Nine;
                break;
        }
    }
}
