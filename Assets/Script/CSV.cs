using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class CSV : MonoBehaviour
{
    private float time;
    private float time_all;
    // private int i;
    private Number Number;
    private string name1;
    public string Button_Variation;
    public string name;
    public string FB;
    public string Button_Shape;
    private int count;
    private int button_count;
    public GameObject Sphere;
    private string[] header;
    private int rnd;
    private int ex_count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        time = 0.0f;
        //time_all = 0.0f;
        button_count = 0;
        rnd = 0;
        string[] header = { "time_all","time", "position_x", "position_y", "position_z","Button","Count" };

        Number = this.GetComponent<Number>();
    }
    // Update is called once per frame
    void Update()
    {
        //ここに処理
        StreamWriter sw;
        FileInfo fi;
        time += Time.deltaTime;
        time_all += Time.deltaTime;
        DateTime now = DateTime.Now;

        fi = new FileInfo(/*Application.streamingAssetsPath*/ Application.dataPath  +  Button_Variation + "_" + Button_Shape + "_" + FB + "_" + name + ".csv");
        sw = fi.AppendText();
        if(button_count == 1){
            rnd = Number.rnd1;
        } else if(button_count == 2){
            rnd = Number.rnd2;
        } else if(button_count == 3){
            rnd = Number.rnd3;
        } else if(button_count == 4){
            rnd = Number.rnd4;
        } else if(button_count == 5){
            rnd = Number.rnd5;
        } else if(button_count == 6){
            rnd = Number.rnd6;
        } else if(button_count == 7){
            rnd = Number.rnd7;
        }                                                                                     
            
        Vector3 rotation = Sphere.transform.eulerAngles;
        if(rotation.x > 270){
            rotation.x = rotation.x - 360;
        }
        if(rotation.y > 270){
            rotation.y = rotation.y - 360;
        }
        if(rotation.z > 270){
            rotation.z = rotation.z - 360;
        }

        sw.WriteLine($"{time_all},{time},{Sphere.transform.position.x},{Sphere.transform.position.y},{Sphere.transform.position.z},{rnd},{count}");
        sw.Flush();
        sw.Close();
        
        if(Input.GetKeyDown(KeyCode.Return)){
            if(button_count < 7){
                count = count + 1;
                time = 0.0f;
                button_count = button_count + 1;
            }          
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            count = count + 1;
            time = 0.0f;
            button_count = 1;
        }
    }
}

