using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class RecordPosition : MonoBehaviour
{
    public Transform targetObject; // 位置を記録するオブジェクト
    public Transform referenceObject; // 位置の基準となるオブジェクト
    public string outputPath = "Assets/CSVFiles/"; // 書き出し先の相対パス
    public string fileName = ""; // CSVファイル名
    private string filePath;
    StreamWriter sw;

    private bool isRecording = false; // 録画中かどうかを示すフラグ

    private void Start()
    {
        // ファイル名にランダムな文字列(3文字)を付与
        fileName += "_";
        for (int i = 0; i < 3; i++)
        {
            fileName += (char)Random.Range(97, 123);
        }
        fileName += ".csv";
        filePath = Path.Combine(outputPath, fileName);
        sw = new StreamWriter(filePath);
        string data = "Time,position.x,position.y,position.z\n";
        sw.WriteLine(data);
        sw.Close();
    }

    private void Update()
    {
        //ターゲットオブジェクトの相対位置を計算
        Vector3 relativePosition = targetObject.position;
        if (referenceObject != null ){
            relativePosition = referenceObject.InverseTransformPoint(targetObject.position);
        }

        if (isRecording && targetObject.transform.hasChanged)
        {
            targetObject.transform.hasChanged = false;

            string data = $"{Time.time}, {relativePosition.x}, {relativePosition.y}, {relativePosition.z}\n";
            sw = new StreamWriter(filePath, true);
            sw.WriteLine(data);
            sw.Close();
        }
    }

    public void StartRecording()
    {
        isRecording = true;
        Debug.Log("Start recording " + targetObject.gameObject.name + " position");
    }

    public void StopRecording()
    {
        isRecording = false;
        Debug.Log("Stop recording " + targetObject.gameObject.name + " position");
    }

    private void OnApplicationQuit()
    {
        if (isRecording){
            StopRecording();
        }
    }
}

[CustomEditor(typeof(RecordPosition))]
public class RecordPositionEditor : Editor
{
    /// <summary>
    /// InspectorのGUIを更新
    /// </summary>
    public override void OnInspectorGUI(){
        //元のInspector部分を表示
        base.OnInspectorGUI ();

        RecordPosition recorder = target as RecordPosition;
        
        //ボタンを表示
        if (GUILayout.Button("Start Recording")){
            recorder.StartRecording();
        }  
        if (GUILayout.Button("Stop Recording")){
            recorder.StopRecording();
        }  
    }
}
