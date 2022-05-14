using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    [SerializeField]
    Text countText;

    [SerializeField]
    Text text;

    [SerializeField]
    InputField myEditText;

    int count = 0;

    int listCount = 0;

    void Start()
    {
        StaticClass.Initialize();

        StaticClass.AddPair("Какой сегодня день", "Суббота", 1);
        StaticClass.AddPair("Какая сегодня дата", "14 мая", 2);
        StaticClass.AddPair("Как тебя зовут", "Андрей", 3);
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = count.ToString();

        text.text = StaticClass.GetKey(listCount);
    }

    public void IncrementCount()
    {
        count++;
    }


    public void InputText()
    {
        string myAnswer = myEditText.text;

        if (myAnswer.ToLower() == StaticClass.GetValue(listCount).ToLower())
        {
            count += StaticClass.GetPoint(listCount);
        }
        else
        {
            count -= StaticClass.GetPoint(listCount);
        }



        listCount++;
        if (listCount == StaticClass.GetQuestionCount())
            listCount = 0; 
    }
}
