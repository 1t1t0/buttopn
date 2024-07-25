using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UIを適用
using UnityEngine.SceneManagement; // シーン切り替えに必要

public class Scene_Change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Data.practice_rnd = Random.Range(0, 5);//練習シーンの選択
        // Data.scene_rnd = Random.Range(0,2);//本番シーンの選択
    }

    // Update is called once per frae
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow)){//migi 矢印が押された
            if(Data.practice_actived == 0 && Data.practice_count != 4){
                PracticeSceneChange();
            } else if(Data.practice_actived == 1 && Data.scene_count != 3){
                ExperimentSceneChange();
            } else {
                SceneManager.LoadSceneAsync("End");
            }   
         }
    }

    private void PracticeSceneChange(){
        Data.practice_rnd = Random.Range(0, 4);//練習シーンの選択
        while(Data.practice[Data.practice_rnd] == 1){
            Data.practice_rnd = Random.Range(0, 4);
        }
        if(Data.practice_rnd == 0){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("3D_practice");
        } else if(Data.practice_rnd == 1){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("3D_Audio_Practice");
        } else if(Data.practice_rnd == 2){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("3D_Animation_Practice");
        } else if(Data.practice_rnd == 3){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("3D_Audio_Animation_Practice");
        } 
    }

    private void ExperimentSceneChange(){ 
        if(Data.practice_rnd == 0){
            SceneManager.LoadScene("3D");
            Data.practice_actived = 0;    
        }
        if(Data.practice_rnd == 1){
            SceneManager.LoadScene("3D_Audio_S");
            Data.practice_actived = 0;  
        }
        if(Data.practice_rnd == 2){
           SceneManager.LoadScene("3D_Animation_S");
            Data.practice_actived = 0;  
        }
        if(Data.practice_rnd == 3){
            SceneManager.LoadScene("3D_Audio_Animation_S");
            Data.practice_actived = 0;  
        }
    }
}

    