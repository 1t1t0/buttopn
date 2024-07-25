using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class Number : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI testText1;
    public TextMeshProUGUI testText2;
    public TextMeshProUGUI testText3;
    public TextMeshProUGUI testText4;
    public TextMeshProUGUI testText5;
    public TextMeshProUGUI testText6;
    public TextMeshProUGUI testText7;

    private string select_number1;
    private string select_number2;
    private string select_number3;
    private string select_number4;
    private string select_number5;
    private string select_number6;
    private string select_number7;

    public int rnd1;
    public int rnd2;
    public int rnd3;
    public int rnd4;
    public int rnd5;
    public int rnd6;
    public int rnd7;

    private int Count;
     
    // Start is called before the first frame update
    void Start()
    {
        Count = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if(Count > 0){
                rnd1 = Random.Range(1, 10);
                select_number1 = rnd1.ToString("0");
                testText1.text = select_number1;

                rnd2 = Random.Range(1, 10);
                select_number2 = rnd2.ToString("0");
                testText2.text = select_number2;

                rnd3 = Random.Range(1, 10);
                select_number3 = rnd3.ToString("0");
                testText3.text = select_number3;

                rnd4 = Random.Range(1, 10);
                select_number4 = rnd4.ToString("0");
                testText4.text = select_number4;

                rnd5 = Random.Range(1, 10);
                select_number5 = rnd5.ToString("0");
                testText5.text = select_number5;

                rnd6 = Random.Range(1, 10);
                select_number6 = rnd6.ToString("0");
                testText6.text = select_number6;

                rnd7 = Random.Range(1, 10);
                select_number7 = rnd7.ToString("0");
                testText7.text = select_number7;
                Count = Count - 1;
            }
        }
    }
}
