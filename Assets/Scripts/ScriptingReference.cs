using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// classes
public class ScriptingReference : MonoBehaviour {

    // variables
    public int a = 1;
    public float b = 1.0f;
    public string word = "punk metal";
    public char c = 'c';
    public bool d = true;

    // functions
    void FunctionExample() {
        float e = a + b;
        print(e); // 2
        print(word); //punk metal
        print(d); // true

        a = 1;
        if (a == b) {
            print("they are equal");
        }
    }

    int Add(int a, int b) {
        return a + b;
    }

    void otherFunction() {
        int a = Add(1, 2);
        FunctionExample();
    }

    private void Update()
    {
        FunctionExample();
        otherFunction();
    }
}
