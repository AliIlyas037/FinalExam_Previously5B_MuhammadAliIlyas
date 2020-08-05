using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Blockterrain : MonoBehaviour
{
    public GameObject myPrefab;
    private Vector3 Cubes;
    private float radius = 1;
    private int numCubes = 37;
    public static bool tf;
    private static System.Random random = new System.Random();
    public static int correctLanguageCount;



    // Start is called before the first frame update
    void Start()
    {
        correctLanguageCount = 0;
        List<string> results = createBalancedLanguage();
        Debug.Log("String genrated >>");
        int i = 0;
        while (numCubes > 0)
        {


            Cubes = new Vector3(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(1.1f, 1.1f), UnityEngine.Random.Range(-15, 15));


            if (Physics.CheckSphere(Cubes, radius))
            {

            }
            else
            {
                Instantiate(myPrefab, Cubes, Quaternion.identity);
                myPrefab.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = results[i];
                myPrefab.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().color = Color.black;
                if (IsBalanced(results[i]))
                {
                    myPrefab.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().color = new Color32(4, 255, 29, 255);
                }
                else
                {
                    myPrefab.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().color = Color.black;
                }
                i++;
                numCubes = numCubes - 1;
            }

            /*for (int j = 0; j < results.Count; j++)
            {
                if (IsBalanced(results[i]))
                {
                    myPrefab.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().color = Color.blue;
                }
            }*/
        }

    }



    public static List<string> RandomString()
    {
        List<string> list_of_strings = new List<string>();
        int x;
        for (int i = 0; i <= 37; i++)
        {
            x = UnityEngine.Random.Range(13, 37);
            const string chars = "XA7()";
            string val = new string(Enumerable.Repeat(chars, 11)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            list_of_strings.Add(val);

        }

        for (int i = 0; i < list_of_strings.Count; i++)
        {
            if (IsBalanced(list_of_strings[i]))
            {
                correctLanguageCount = correctLanguageCount + 1;
            }
        }

        return list_of_strings;
    }

    public static List<string> createBalancedLanguage()
    {
        int length_before;
        int length_after;
        int len_difference;
        int brackets_count;
        string open_string;
        string close_string;
        int correct_language_count;

        correct_language_count = 12 - correctLanguageCount;
        List<string> randomStrings = RandomString();

        for (int i = 0; i < correct_language_count; i++)
        {
            correctLanguageCount = correctLanguageCount + 1;
            length_before = 0;
            length_after = 0;
            len_difference = 0;
            brackets_count = 0;
            open_string = "";
            close_string = "";

            length_before = randomStrings[i].Length;
            randomStrings[i] = randomStrings[i].Replace("(", "").Replace(")", "");
            length_after = randomStrings[i].Length;
            len_difference = length_before - length_after;
            if (len_difference % 2 == 0)
            {
                brackets_count = len_difference / 2;
            }

            else
            {
                len_difference = len_difference + 1;
                brackets_count = len_difference / 2;
            }

            for (int j = 0; j < brackets_count; j++)
            {
                open_string = "(" + open_string;
                close_string = ")" + close_string;
            }

            randomStrings[i] = open_string + randomStrings[i] + close_string;
            //   string first = val[i].Substring(0, val[i].Length / 2);
            //   string second = val[i].Substring(val[i].Length / 2 + 1, val[i].Length - 1);

        }

        return randomStrings;
    }

    public static bool IsBalanced(string input)
    {

        Dictionary<char, char> bracketPairs = new Dictionary<char, char>() {
            { '(', ')' }
        };

        Stack<char> brackets = new Stack<char>();

        try
        {
            // Iterate through each character in the input string
            foreach (char c in input)
            {
                // check if the character is one of the 'opening' brackets
                if (bracketPairs.Keys.Contains(c))
                {
                    // if yes, push to stack
                    brackets.Push(c);
                }
                else
                // check if the character is one of the 'closing' brackets
                    if (bracketPairs.Values.Contains(c))
                {
                    // check if the closing bracket matches the 'latest' 'opening' bracket
                    if (c == bracketPairs[brackets.First()])
                    {
                        brackets.Pop();
                    }
                    else
                        // if not, its an unbalanced string
                        return false;
                }
                else
                    // continue looking
                    continue;
            }
        }
        catch
        {
            // an exception will be caught in case a closing bracket is found, 
            // before any opening bracket.
            // that implies, the string is not balanced. Return false
            return false;
        }

        // Ensure all brackets are closed
        return brackets.Count() == 0 ? true : false;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
