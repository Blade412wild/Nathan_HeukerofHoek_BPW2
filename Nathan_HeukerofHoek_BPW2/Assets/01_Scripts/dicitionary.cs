using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class dicitionary : MonoBehaviour
{
    
    Dictionary<string, int> MyDictionary = new Dictionary<string, int>();
    // Start is called before the first frame update

    private void Start()
    {
        MyDictionary.Add("hallo", 5);
        MyDictionary.Add("nee", 10);
        int someValue = MyDictionary["hallo"];
        foreach (KeyValuePair<string, int> keyValuePair in MyDictionary)
        {
            Debug.Log(keyValuePair.Key + " " + keyValuePair);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
