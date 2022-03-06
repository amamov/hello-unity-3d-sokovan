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
        name = title;

        //* C# Function
        var sizeOfCircle = 30f;
        var radius = GetRadius(sizeOfCircle);
        Debug.Log(radius);

        //* type casting
        var width = 100;
        var widthDetail = 100.3f;
        widthDetail = width;
        width = (int) widthDetail;

        //* condition
        if (isSexy || !isSexy && isSexy) Debug.Log("I'am sexy");

        //* array 
        int[] scores = {90, 45, 30, 100};

        //* class
        var amamov = new Animal();
        amamov.name = "yoon sang seok";
        amamov.sound = "Bark!!";
        amamov.weight = 74.3f;

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


public class Animal
{
    public string name;
    public string sound;
    public float weight;
}
