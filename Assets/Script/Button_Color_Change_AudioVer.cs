using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Color_Change_AudioVer : MonoBehaviour
{
    private Color32 button_normal_color;//ボタンの通常の色
    private Color32 button_highlight_color;//ボタンの色が変化したときの色
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
    public Button Push_Button;//押すボタン
    public Button Prev_Push_Button;
    private Number_Audio Number_Audio;

    private int count;

    // Start is called before the first frame update
    void Start()
    {
        button_normal_color = new Color32(0 ,0, 0, 255);
        button_highlight_color = new Color32(0, 0, 255, 255);
        Number_Audio = this.GetComponent<Number_Audio>();
        count = 1;
        Distance  =0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            Prev_Push_Button = Push_Button;
            ButtonStateColorChange(Prev_Push_Button, button_normal_color, 0);
            count = count + 1;
            if(count == 8){
                
            }
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Prev_Push_Button = Push_Button;
            ButtonStateColorChange(Prev_Push_Button, button_normal_color, 0);
            count = 1;
        }
        if(count == 1){
            ButtonSelect(Number_Audio.rnd1);
            if(Circle.transform.position.z >= Distance){
                ButtonStateColorChange(Push_Button, button_highlight_color, 0);
            } else if(Circle.transform.position.z < Distance){
                ButtonStateColorChange(Push_Button, button_normal_color, 0);
            }
        }
        if(count == 2){
            ButtonSelect(Number_Audio.rnd2);
            if(Circle.transform.position.z >= Distance){
                ButtonStateColorChange(Push_Button, button_highlight_color, 0);
            } else if(Circle.transform.position.z < Distance){
                ButtonStateColorChange(Push_Button, button_normal_color, 0);
            }
        }
        if(count == 3){
            ButtonSelect(Number_Audio.rnd3);
            if(Circle.transform.position.z >= Distance){
                ButtonStateColorChange(Push_Button, button_highlight_color, 0);
            } else if(Circle.transform.position.z < Distance){
                ButtonStateColorChange(Push_Button, button_normal_color, 0);
            }
        }
        if(count == 4){
            ButtonSelect(Number_Audio.rnd4);
            if(Circle.transform.position.z >= Distance){
                ButtonStateColorChange(Push_Button, button_highlight_color, 0);
            } else if(Circle.transform.position.z < Distance){
                ButtonStateColorChange(Push_Button, button_normal_color, 0);
            }
        }
        if(count == 5){
            ButtonSelect(Number_Audio.rnd5);
            if(Circle.transform.position.z >= Distance){
                ButtonStateColorChange(Push_Button, button_highlight_color, 0);
            } else if(Circle.transform.position.z < Distance){
                ButtonStateColorChange(Push_Button, button_normal_color, 0);
            }
        }
        if(count == 6){
            ButtonSelect(Number_Audio.rnd6);
            if(Circle.transform.position.z >= Distance){
                ButtonStateColorChange(Push_Button, button_highlight_color, 0);
            } else if(Circle.transform.position.z < Distance){
                ButtonStateColorChange(Push_Button, button_normal_color, 0);
            }
        }
        if(count == 7){
            ButtonSelect(Number_Audio.rnd7);
            if(Circle.transform.position.z >= Distance){
                ButtonStateColorChange(Push_Button, button_highlight_color, 0);
            } else if(Circle.transform.position.z < Distance){
                ButtonStateColorChange(Push_Button, button_normal_color, 0);
            }
        }       
    }
    //押しボタンの選択
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
    //ボタンの色の変化
    private void ButtonStateColorChange(Button button, Color32 color, int changeState)
    {
        ColorBlock colorblock = button.colors;
        switch (changeState)
        {
            case 0://normalColor
                colorblock.normalColor = color;
                break;
            case 1://highlightedColor
                colorblock.highlightedColor = color;
                break;
            case 2://pressedColor
                colorblock.pressedColor = color;
                break;
            case 3://selectedColor
                colorblock.selectedColor = color;
                break;
            case 4://disabledColor
                colorblock.disabledColor = color;
                break;
        }
        button.colors = colorblock;
    }

}

