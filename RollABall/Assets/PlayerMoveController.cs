using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    // �v���C���[��Rigidbody
    private Rigidbody playerRigidbody;

    // GameState���Q�Ƃ���
    public GameState GameState;

    // GameResultViewer���Q�Ƃ���
    public GameResultViewer GameResultViewer;

    // Start is called before the first frame update
    void Start()
    {
        // �v���C���[��Rigidbody���A�^�b�`����GameObject����擾���܂�
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

        // vector3�^�̕ϐ�move��(���E�L�[,0,�㉺�L�[)�̒l�������܂�
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // playerRigidbody��move�����̗͂������܂�
        playerRigidbody.AddForce(move);
    }
}
