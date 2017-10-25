using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class CipherManager : MonoBehaviour {
    public Text text;
    public int num;
    public string cipher;
    private string encodedString = "";
    //private char[] charArr = new char[26];//['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
    void Start () {
        //charArr = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        string[] cipherArrary = Regex.Split(cipher, " ");
        for(int i = 0; i < cipherArrary.Length; i++)
        {
            encodedString += Cipher(cipherArrary[i]);
        }
        text.text = encodedString.ToString();
	}
	private string Cipher(string _s)
    {
        print(_s);

        char[] originalArr = _s.ToCharArray();
        int firstCharId = 'a';
        int offset = ('z' - 'a') + 1;
        for (int i = 0; i < originalArr.Length; i++)
        {
            char oldId = originalArr[i];
            int oldIdInAlphabet = oldId - firstCharId;
            int newId = (oldIdInAlphabet + num) % offset;
            char newCharId = (char)(firstCharId + newId);
            originalArr[i] = newCharId;
        }
        return _s = " " + new string(originalArr);
    }
}
