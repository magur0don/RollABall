using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    // プレイヤーのRigidbody
    private Rigidbody playerRigidbody;

    // GameStateを参照する
    public GameState GameState;

    // GameResultViewerを参照する
    public GameResultViewer GameResultViewer;

    // Start is called before the first frame update
    void Start()
    {
        // プレイヤーのRigidbodyをアタッチしたGameObjectから取得します
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -1)
        {
            GameState.SetGameProgressState( GameState.GameProgressStates.GameResult);
            GameResultViewer.ResultText.text = "Game Over";
            return;
        }

        // vector3型の変数moveに(左右キー,0,上下キー)の値を代入します
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // playerRigidbodyにmove向きの力を加えます
        playerRigidbody.AddForce(move);
    }
}
