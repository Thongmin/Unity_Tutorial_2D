using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1 = 0;
    public int number2 = 0;

    void Start()
    {
        int addResult = AddMethod();
        
        int minusResult = MinusMethod();

        Debug.Log($"더한 값 : {addResult} / 뺀 값 : {minusResult}");
    }

    int AddMethod()
    {
        int result = number1 + number2;

        return result;
    }
    int MinusMethod()
    {
        int result = number1 - number2;

        return result;
    }
}
