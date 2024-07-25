using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Count : MonoBehaviour
{
    private int Count_number;
    public TextMeshProUGUI testText1;
    private string select_number;
    // Start is called before the first frame update
    void Start()
    {
        Count_number = 5;
        select_number = Count_number.ToString("0");
        testText1.text = select_number;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            if(Count_number != 0){
                Count_number = Count_number - 1;
                select_number = Count_number.ToString("0");
                testText1.text = select_number;              
            }
        }
    }
}
