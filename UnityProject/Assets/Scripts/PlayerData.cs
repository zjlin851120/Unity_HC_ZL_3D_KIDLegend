using UnityEngine;

[CreateAssetMenu(fileName = "玩家資料", menuName = "KID/玩家資料")]
public class PlayerData : ScriptableObject
{
    [Header("血量"), Range(200, 10000)]
    public float hp;
    public float hpMax;
    [Header("子彈位移")]
    public float attackY;
    public float attackZ;
    [Header("攻擊冷卻時間"), Range(0, 1.5f)]
    public float cd = 0.7f;
}
