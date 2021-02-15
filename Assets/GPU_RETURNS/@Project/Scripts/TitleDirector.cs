using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleDirector : MonoBehaviour
{
    // インスペクタで設定する値
    public string nextScene;    // シーン名
    public float fadeTime;      // フェード時間
    public int sceneState;      // シーンの状態
    public string bgmName;      // BGMファイル名

    bool sceneEnd;

    void Start()
    {
        sceneState = 0;

        sceneEnd = false;

        // BGM再生
        BgmManager.Instance.Play(bgmName);
    }

    void Update()
    {
        // 任意のキーで次のシーンへ
        if (Input.GetKeyDown(KeyCode.Return))
        {
            sceneEnd = true;
            SeManager.Instance.Play("Return");
        }

        if(sceneEnd == true)
        {
            sceneState++;
        }

        if (sceneState >= 300)
        {
            // BGM停止
            BgmManager.Instance.Stop();

            // フェード時間を設定してシーン遷移
            FadeManager.Instance.LoadScene(nextScene, fadeTime);
        }
    }

}