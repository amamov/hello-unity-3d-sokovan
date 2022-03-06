using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //* C# Var
        int age = 25;
        float height = 183.3829f; // 32bit (소숫점 아래 7자리까지 정확)
        double pi = 3.14159265359; // 64bit (소숫점 아래 15자리까지 정확)
        bool isSexy = true;
        char grade = 'A'; // character 한 문자
        string title = "Hello World!!";
        Debug.Log(age);
        Debug.Log(pi);
        Debug.Log(title + " bro!" + pi);
        var name = "yoon sang seok"; // auto typing
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}
