using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class SlangRegex : MonoBehaviour
{
    static string patternSlang = "(개|개새|씨발|니애)";
    public List<string> slangs;
    

    void Start()
    {
        for (int i = 0; i < slangs.Count; i++)
        {
            string result = Regex.Replace(slangs[i], patternSlang, "*");
            Debug.Log($"바른말 고운말 :{result}");
        }        
    }
    /// <summary>
    /// 내가만든 함수입니다!!! 전달받은 정수를 출력합니다
    /// </summary>
    /// <param name="a">정수a를 받습니다</param>
    public void MyFunction(int a)
    {
        Debug.Log(a);
    }
}
