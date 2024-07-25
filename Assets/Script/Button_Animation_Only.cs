using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Animation2 : MonoBehaviour
{
    public GameObject Circle;
    public GameObject One;
    public GameObject Two;
    public GameObject Three;
    public GameObject Four;
    public GameObject Five;
    public GameObject Six;
    public GameObject Seven;
    public GameObject Eight;
    public GameObject Nine;
    private Number Number;
    private float Distance;
    public GameObject Push_Button;
    public GameObject Prev_Push_Button;
    private float prev_position_z;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 1;
        Number= this.GetComponent<Number>();
        Number= this.GetComponent<Number>();
        Distance = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            Prev_Push_Button = Push_Button;
            Transform ButtonTransform = Prev_Push_Button.transform;
            Vector3 Button_position = ButtonTransform.position;
            Button_position.z = 0.0f;
            ButtonTransform.position = Button_position;
            count = count + 1;
            if(count == 8){
                count = 1;
            }
        }

        if(count == 1){
            float dis = prev_position_z - Circle.transform.position.z;
            ButtonSelect(Number
    .rnd1);
            if(Circle.transform.position.z >= Distance && dis < 0.0f){
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.005f;
                ButtonTransform.position = Button_position;
            } else if(dis > 0.0f) {
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.0f;
                ButtonTransform.position = Button_position;
            }
        } 
        if(count == 2){
            float dis = prev_position_z - Circle.transform.position.z;
            ButtonSelect(Number
    .rnd2);
            if(Circle.transform.position.z >= Distance && dis < 0.0f){
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.005f;
                ButtonTransform.position = Button_position;
            } else if(dis > 0.0f) {
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.0f;
                ButtonTransform.position = Button_position;
            }
        } 
        if(count == 3){
            float dis = prev_position_z - Circle.transform.position.z;
            ButtonSelect(Number
    .rnd3);
            if(Circle.transform.position.z >= Distance && dis < 0.0f){
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.005f;
                ButtonTransform.position = Button_position;
            } else if(dis > 0.0f) {
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.0f;
                ButtonTransform.position = Button_position;
            }
        } 
        if(count == 4){
            float dis = prev_position_z - Circle.transform.position.z;
            ButtonSelect(Number
    .rnd4);
            if(Circle.transform.position.z >= Distance && dis < 0.0f){
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.005f;
                ButtonTransform.position = Button_position;
            } else if(dis > 0.0f) {
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.0f;
                ButtonTransform.position = Button_position;
            }
        } 
        if(count == 5){
            float dis = prev_position_z - Circle.transform.position.z;
            ButtonSelect(Number
    .rnd5);
            if(Circle.transform.position.z >= Distance && dis < 0.0f){
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.005f;
                ButtonTransform.position = Button_position;
            } else if(dis > 0.0f) {
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.0f;
                ButtonTransform.position = Button_position;
            }
        } 
        if(count == 6){
            float dis = prev_position_z - Circle.transform.position.z;
            ButtonSelect(Number
    .rnd6);
            if(Circle.transform.position.z >= Distance && dis < 0.0f){
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.005f;
                ButtonTransform.position = Button_position;
            } else if(dis > 0.0f) {
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.0f;
                ButtonTransform.position = Button_position;
            }
        } 
        if(count == 7){
            float dis = prev_position_z - Circle.transform.position.z;
            ButtonSelect(Number
    .rnd7);
            if(Circle.transform.position.z >= Distance && dis < 0.0f){
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.005f;
                ButtonTransform.position = Button_position;
            } else if(dis > 0.0f) {
                Transform ButtonTransform = Push_Button.transform;
                Vector3 Button_position = ButtonTransform.position;
                Button_position.z = 0.0f;
                ButtonTransform.position = Button_position;
            }
        }
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
