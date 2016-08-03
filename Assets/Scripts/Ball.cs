/*
作者名称:YHB

脚本作用:控制球的运动

建立时间:2016.8.3.14.53
*/

using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    #region 字段
    public float moveSpeed = 300f;
    private Rigidbody2D r2d;
    #endregion

    void Start()
    {
        r2d = this.GetComponent<Rigidbody2D>();

        r2d.velocity = Vector2.right * moveSpeed * Direction();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            float angle = Angle(this.transform.position, collision.transform.position, collision.collider.bounds.size.y);

            int x = collision.gameObject.name == "Player1" ? 1 : -1;

            Vector2 dir = new Vector2(x, angle).normalized;

            r2d.velocity = dir * moveSpeed;

            //速度增加
            moveSpeed *= 1.006f;
        }
    }

    #region  计算角度方法
    float Angle(Vector3 ballPos, Vector3 playerPos, float playerHeight)
    {
        return (ballPos.y - playerPos.y) / playerHeight;
    }
    #endregion

    #region 初始化方位
    int Direction()
    {
        int x = Random.Range(1, 101);
        int dir = (x <= 50) ? 1 : -1;
        return dir;
    }
    #endregion
}
