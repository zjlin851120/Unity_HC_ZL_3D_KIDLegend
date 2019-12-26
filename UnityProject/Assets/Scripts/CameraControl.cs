using UnityEngine;

namespace KID
{
    public class CameraControl : MonoBehaviour
    {
        [Header("速度"), Range(0, 100)]
        public float speed = 1.5f;
        [Header("上方限制")]
        public float top;
        [Header("下方限制")]
        public float bottom;

        private Transform player;

        private void Start()
        {
            player = GameObject.Find("鼠王").transform;
        }

        // 在 Update 之後才執行：攝影機追蹤、物件追蹤
        private void LateUpdate()
        {
            Track();
        }

        /// <summary>
        /// 攝影機追蹤效果
        /// </summary>
        private void Track()
        {
            Vector3 posP = player.position;     // 玩家
            Vector3 posC = transform.position;  // 攝影機

            posP.x = 0;     // 固定 X 軸
            posP.y = 18;    // 固定 Y 軸
            posP.z -= 18;   // 放在玩家後方 -= 18

            posP.z = Mathf.Clamp(posP.z, bottom, top);  // 玩家.Z 夾住 上方限制 ~ 下方限制

            // 攝影機.座標 = 三維插值(A座標，B座標，百分比)
            transform.position = Vector3.Lerp(posC, posP, 0.3f * Time.deltaTime * speed);
        }
    }
}
