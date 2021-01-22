using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDirector : MonoBehaviour
{
    // インスペクタで設定する値
    public string nextScene;    // シーン名
    public float fadeTime;      // フェード時間
    public KeyCode keyCode;     // シーン遷移キー
    public int sceneState;      // シーンの状態
    public string bgmName;      // BGMファイル名

    // ゴールオブジェクトのフラグを取得
    Goal goal;


    void Start()
    {
        sceneState = 0;

        // キーがインスペクターで設定されてない時はエンターキーをセットする
        if(keyCode == KeyCode.None)
        {
            keyCode = KeyCode.Return;
        }

        // ゴールコンポーネントを取得
        goal = GameObject.Find("Goal").GetComponent<Goal>();

        // BGM再生
        BgmManager.Instance.Play(bgmName);
    }

    void Update()
    {
        // ゴールフラグが true になると sceneState が99になる
        if(goal.isGoal() == true) 
        {
            sceneState = 99;
            BgmManager.Instance.Stop();
        }

        // シーンステートが99の時、任意のキーで次のシーンへ
        if (sceneState == 99 && Input.GetKeyDown(keyCode))
        {
            //Debug.Log("LoadScene");
            // フェード時間を設定してシーン遷移
            FadeManager.Instance.LoadScene(nextScene, fadeTime);
        }
    }

}