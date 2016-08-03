/*
作者名称:YHB

脚本作用:制定不同的按键控制两个玩家

建立时间:2016.8.3.14.08
*/

using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    #region 字段
    private float moveSpeed = 666f;
    private Rigidbody2D r2d;
    #endregion

    #region Unity内置函数
    void Start()
    {
        r2d = this.GetComponent<Rigidbody2D>();
    }
    void Update()//每帧执行
    {
        PlayerController();
    }
    #endregion

    #region 控制方法
    void PlayerController()
    {
        float axisY = 0f;

        if (this.gameObject.name == "Player1")
        {
            axisY = Input.GetAxisRaw("Player1");
        }
        else if (this.gameObject.name == "Player2")
        {
            axisY = Input.GetAxisRaw("Player2");
        }

        r2d.velocity = new Vector2(0, axisY * moveSpeed);
    }
    #endregion
}
