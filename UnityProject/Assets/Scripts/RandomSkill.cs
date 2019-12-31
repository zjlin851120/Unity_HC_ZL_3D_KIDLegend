using UnityEngine;
using UnityEngine.UI;   // 引用介面 API

namespace KID
{
    public class RandomSkill : MonoBehaviour
    {
        [Header("技能圖片：模糊與正常")]
        public Sprite[] spriteBlurs;        // 模糊圖片陣列 16
        public Sprite[] spriteSkills;       // 技能圖片陣列 8

        private Image img;                  // 圖片元件
        private Button btn;                 // 按鈕元件

        private void Start()
        {
            img = GetComponent<Image>();
            btn = GetComponent<Button>();
            // 啟動協程
        }

        // 定義協程方法 捲動效果

        // 按鈕無法點選

        // 迴圈
        // 圖片元件.圖片 = 模糊圖片陣列[編號]
        
        // 隨機挑選 技能圖片陣列

        // 按鈕可以點選
    }
}
