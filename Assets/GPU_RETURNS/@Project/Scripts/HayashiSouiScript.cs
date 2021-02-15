using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HayashiSouiScript : MonoBehaviour
{
    string tachaScene = "Stage10";
    // Start is called before the first frame update
    void Start()
    {
        //tachaScene.name = "Stage10";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        SceneManager.LoadScene(tachaScene);
    }
}
