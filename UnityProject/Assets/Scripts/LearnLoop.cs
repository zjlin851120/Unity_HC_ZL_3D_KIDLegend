using UnityEngine;

public class LearnLoop : MonoBehaviour
{
    private void Start()
    {
        // 不使用迴圈：
        print("哈囉， 1");
        print("哈囉， 2");
        print("哈囉， 3");
        print("哈囉， 4");
        print("哈囉， 5");

        // 執行一次
        if (true)
        {

        }

        // while 迴圈：持續執行 () 為 false
        int count = 0;

        while (count < 500)
        {
            count++;
            print("嗨 while 迴圈：" + count);
        }

        for (int number = 0; number < 10; number++)
        {
            print("嗨 for 迴圈：" + number);
        }
    }
}
