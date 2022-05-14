using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticClass
{
    static List<string> listQuestion;

    static List<string> listAnswer;

    static List<int> listPoint;


    public static void Initialize()
    {
        listAnswer = new List<string>();
        listPoint = new List<int>();
        listQuestion = new List<string>();
    }

    public static void AddPair(string key, string value, int pointCount)
    {
        listQuestion.Add(key);
        listAnswer.Add(value);
        listPoint.Add(pointCount);
    }

    public static string GetKey(int index)
    {
        if (index >= listQuestion.Count)
            return "";
        return listQuestion[index];
    }

    public static string GetValue(int index)
    {
        if (index >= listAnswer.Count)
            return "";
        return listAnswer[index];
    }

    public static int GetPoint(int index)
    {
        if (index >= listPoint.Count)
            return 0;
        return listPoint[index];
    }

    public static int GetQuestionCount()
    {
        return listPoint.Count;
    }
}
