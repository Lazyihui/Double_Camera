// #define UNITY_EDITOR
// #if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEditor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEditor.EditorApplication.isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
// #endif