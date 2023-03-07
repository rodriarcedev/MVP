using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOrderString : MonoBehaviour
{
    public int maxLength;
    // Start is called before the first frame update
    void Start()
    {
        OrderStrings(new List<string>() {
        "Rodric",
        "new",
        "a"
        
        }); 
    }

    private string OrderStrings(List<string> stringsToOrder)
    {

      
        Debug.Log("The Max Length is " + maxLength);
        string newWord = string.Empty;
        for (int i = 0; i < maxLength; i++)// First Get The Max Length Value
        {
            foreach (var word in stringsToOrder)
            {

                if (maxLength == 0)
                {
                    maxLength = word.Length;
                }
                else if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                }

            }
            foreach (var word in stringsToOrder)// Loop the strings to concat the letters
            {
                if (word.Length > i)
                {
                   newWord = string.Concat(newWord, word[i]);
                }
                else
                {
                    newWord = string.Concat(newWord, "e");
                }
               
            }
           
        }
        return newWord;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
