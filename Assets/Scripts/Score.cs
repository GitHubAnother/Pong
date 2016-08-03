/*
作者名称:YHB

脚本作用:计分作用

建立时间:2016.8.3.15.50
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    #region 字段
    public Text player1;
    public Text player2;

    private int player1Score = 0;
    private int player2Score = 0;
    #endregion

    #region 两个事件注册的方法
    void player1AddScore()
    {
        player1Score++;
        player1.text = player1Score.ToString();
    }
    void player2AddScore()
    {
        player2Score++;
        player2.text = player2Score.ToString();
    }

    #endregion

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            if (collision.transform.position.x < 0)
            {
                player2AddScore();
            }
            else
            {
                player1AddScore();
            }
        }
    }
}
