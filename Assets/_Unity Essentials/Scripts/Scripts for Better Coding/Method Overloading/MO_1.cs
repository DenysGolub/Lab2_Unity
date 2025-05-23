using UnityEngine;
using System.Collections;

public class SomeClass
{
    //The first Add method has a signature of
    //"Add(int, int)". This signature must be unique.
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    //The second Add method has a sugnature of
    //"Add(string, string)". Again, this must be unique.
    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }
}


public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        SomeClass myClass = new SomeClass();

        //The specific Add method called will depend on
        //the arguments passed in.
        myClass.Add(1, 2);
        myClass.Add("Hello ", "World");
    }
}
