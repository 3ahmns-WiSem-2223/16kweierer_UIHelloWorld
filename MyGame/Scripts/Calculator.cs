using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI text;
    int number;

    public void PlusOne()
    {
        number++;
    }

    public void MinusOne()
    {
        number--;
    }

    private void Update()
    {
        if(number <= 0)
        {
            number = 0;
        }

        text.text = number.ToString();
    }

    public void Clear()
    {
        number = 0;
    }

    public void Sqaure()
    {
        number *= number;
    }

    public void TimesTwo()
    {
        number *= 2;
    }

    public void TimesFour()
    {
        number *= 4;
    }

    public void MinusFour()
    {
        number -= 4;
    }

    public void PlusFour()
    {
        number += 4;
    }
}
