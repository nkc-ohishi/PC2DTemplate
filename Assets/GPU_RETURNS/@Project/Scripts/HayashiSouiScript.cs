using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HayashiSouiScript : MonoBehaviour
{
    [SerializeField]string tachaScene;
    void Start()
    {
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        SceneManager.LoadScene(tachaScene);
    }
}
