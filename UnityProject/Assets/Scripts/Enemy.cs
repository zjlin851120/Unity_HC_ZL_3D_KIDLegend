using UnityEngine;
using UnityEngine.AI;       // 引用 人工智慧 API

public class Enemy : MonoBehaviour
{
    [Header("怪物資料")]
    public EnemyData data;

    private Animator ani;                       // 動畫控制器
    private NavMeshAgent nav;                   // 導覽網格代理器
    private Transform target;                   // 目標變形

    private void Start()
    {
        ani = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
        nav.speed = data.speed;                         // 調整 代理器.速度
        nav.stoppingDistance = data.stopDistance;       

        target = GameObject.Find("鼠王").transform;   // 目標 = 尋找
    }

    private void Update()
    {
        Move();                     // 呼叫移動方法
    }

    // 摺疊 Ctrl + M O
    // 展開 Ctrl + M L

    /// <summary>
    /// 等待
    /// </summary>
    private void Wait()
    {

    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        Vector3 posTarget = target.position;    // 區域變數三維向量 目標位置  = 目標.座標
        posTarget.y = transform.position.y;     // 目標位置.Y = 本身.Y
        transform.LookAt(posTarget);            // 變形.看著(目標位置)
        ani.SetBool("跑步開關", true);           // 動畫.設定布林值(參數，勾選)
        nav.SetDestination(target.position);    // 代理器.設定目的地(目標.座標)
    }

    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    {

    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">接收玩家給予的傷害值</param>
    private void Hit(float damage)
    {

    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }
}
