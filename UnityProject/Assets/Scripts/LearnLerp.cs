using UnityEngine;

public class LearnLerp : MonoBehaviour
{
    public float a = 0;
    public float b = 10;

    public Vector2 v2A = new Vector2(0, 0);
    public Vector2 v2B = new Vector2(100, 100);

    public Color cA, cB, cC;

    public float numbA = 0, numbB = 100;

    public Transform cube;
    public Transform sphere;

    public Transform A, B;

    public int hp = 50;

    private void Start()
    {
        // 數學.插值(A，B，百分比)
        print(Mathf.Lerp(a, b, 0.8f));

        // 二維.插值(二維A，二維B，百分比)
        print(Vector2.Lerp(v2A, v2B, 0.5f));

        // 顏色C = 顏色.插值(顏色A，顏色B，百分比)
        cC = Color.Lerp(cA, cB, 0.7f);

        // 數學.夾住(值，最小值，最大值)
        print(Mathf.Clamp(hp, 0, 100));
    }

    private void Update()
    {
        numbA = Mathf.Lerp(numbA, numbB, 0.3f * Time.deltaTime);

        cube.position = Vector3.Lerp(cube.position, sphere.position, 0.3f * Time.deltaTime);
    }
}
