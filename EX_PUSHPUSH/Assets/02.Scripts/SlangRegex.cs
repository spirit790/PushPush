using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class SlangRegex : MonoBehaviour
{
    static string patternSlang = "(��|����|����|�Ͼ�)";
    public List<string> slangs;
    

    void Start()
    {
        for (int i = 0; i < slangs.Count; i++)
        {
            string result = Regex.Replace(slangs[i], patternSlang, "*");
            Debug.Log($"�ٸ��� �� :{result}");
        }        
    }
    /// <summary>
    /// �������� �Լ��Դϴ�!!! ���޹��� ������ ����մϴ�
    /// </summary>
    /// <param name="a">����a�� �޽��ϴ�</param>
    public void MyFunction(int a)
    {
        Debug.Log(a);
    }
}
