using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        //* C# Var
        var age = 25;
        var height = 183.3829f; // 32bit (소숫점 아래 7자리까지 정확)
        var pi = 3.14159265359; // 64bit (소숫점 아래 15자리까지 정확)
        var isSexy = true;
        var grade = 'A'; // character 한 문자
        var title = "Hello World!!";
        Debug.Log(age);
        Debug.Log(pi);
        Debug.Log(title + " bro!" + pi);
        var name = "yoon sang seok"; // auto typing

        //* C# Function
        var sizeOfCircle = 30f;
        var radius = GetRadius(sizeOfCircle);
        Debug.Log(radius);
    }

    // Update is called once per frame
    private void Update()
    {

    }

    private float GetRadius(float size)
    {
        var pi = 3.14f;
        var radius = Mathf.Sqrt(size / pi);
        return radius;
    }
}
