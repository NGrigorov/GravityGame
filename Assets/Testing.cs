using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Testing : MonoBehaviour
{
    public TextMeshProUGUI text;
    public List<string> myLists;
    // Start is called before the first frame update
    void Start()
    {
        Result res = solveQuadratic(1, 1, 1);
        text.text = res.x1 +" "+ res.x2;
        //myLists = new List<string>();
        //myLists.Add("asd");
        //myLists.Add("dsa");
        //myLists.Add("asd");
        //myLists.Add("dsa");
        //RemoveDuplicates(myLists);
        HashSet<string> myset = new HashSet<string>(myLists);

        //testItems();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    struct Result
    {
        public float x1;
        public float x2;
    };

    Result solveQuadratic(float a, float b, float c)
    {
        float bSquaredMinus4ac = (b*b)-(4*a*c);
        Debug.Log(bSquaredMinus4ac);
        Result result = new Result();
        result.x1 = ((-b + Mathf.Sqrt(bSquaredMinus4ac)) / (2 * a));
        Debug.Log(result.x1);
        result.x2 = ((-b - Mathf.Sqrt(bSquaredMinus4ac)) / (2 * a));
        Debug.Log(result.x2);
        return result;
    }

    //void RemoveDuplicates(List<string> myList)
    //{
    //    var listCount = myList.Count;
    //    for (var i = 0; i < listCount; i = i + 1)
    //    {
    //        for (var j = i + 1; j < listCount; j = j + 1)
    //        {
    //            Debug.Log(j);
    //            if (myList[i] == myList[j])
    //            {
    //                myList.RemoveAt(j);
    //            }
    //        }
    //    }
    //}

    void RemoveDuplicates(List<string> myList)
    {
        var secondlist = new List<string>();
        HashSet<string> myset = new HashSet<string>();
        var listCount = myList.Count;
        for (var i = 0; i < listCount; i = i + 1)
        {
            if (!myset.Contains(myList[i]))
            {
                myset.Add(myList[i]);
                secondlist.Add(myList[i]);
            }
        }

        myList = secondlist;
        Debug.Log(myList[0]);
        Debug.Log(myList[1]);
    }

    class Player
    {
        private List<string> inventory = new List<string>();

        public Player(List<string> items)
        {
            inventory = new List<string>();
            inventory.AddRange(items);
        }

        public List<string> GetItems()
        {
            return inventory;
        }
    }

    void testItems()
    {

        // Jack has a potion and a sword
        var jacksItems = new List<string>();
        jacksItems.Add("potion");
        jacksItems.Add("sword");
        var jack = new Player(jacksItems);

        // Jill’s inventory has all the same items as Jack’s, and additionally she has a helmet

        var jillsItems = new List<string>();
        jillsItems = jack.GetItems();
        jillsItems.Add("helmet");
        var jill = new Player(jillsItems);


        
        Debug.Log(jill.GetItems()[0] + " Jill");
        Debug.Log(jill.GetItems()[1] + " Jill");
        Debug.Log(jill.GetItems()[2] + " Jill");
        Debug.Log(jack.GetItems()[0] + " Jack");
        Debug.Log(jack.GetItems()[1] + " Jack");
        Debug.Log(jack.GetItems()[2] + " Jack");

        
    }
}
