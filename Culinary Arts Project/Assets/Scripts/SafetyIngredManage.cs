using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SafetyIngredManage : MonoBehaviour
{
    [SerializeField]
    TMP_InputField i_Cost1;
    [SerializeField]
    TMP_InputField i_Amt1;
    [SerializeField]
    TMP_InputField i_Cost2;
    [SerializeField]
    TMP_InputField i_Amt2;
    [SerializeField]
    TMP_InputField i_Cost3;
    [SerializeField]
    TMP_InputField i_Amt3;
    [SerializeField]
    TMP_InputField i_Cost4;
    [SerializeField]
    TMP_InputField i_Amt4;
    [SerializeField]
    TMP_InputField i_Cost5;
    [SerializeField]
    TMP_InputField i_Amt5;
    [SerializeField]
    TMP_InputField i_Cost6;
    [SerializeField]
    TMP_InputField i_Amt6;
    [SerializeField]
    TMP_InputField i_Cost7;
    [SerializeField]
    TMP_InputField i_Amt7;
    [SerializeField]
    TMP_InputField i_Cost8;
    [SerializeField]
    TMP_InputField i_Amt8;
    [SerializeField]
    TMP_InputField i_MR;
    [SerializeField]
    TMP_InputField i_NumItems;
    [SerializeField]
    TMP_Text Price;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float Cost1 = 0;
            float Amt1 = 0;
            Debug.Log(float.TryParse(i_Cost1.text, out Cost1));
            Debug.Log(float.TryParse(i_Amt1.text, out Amt1));
            float Cost2 = 0;
            float Amt2 = 0;
            Debug.Log(float.TryParse(i_Cost2.text, out Cost2));
            Debug.Log(float.TryParse(i_Amt2.text, out Amt2));
            float Cost3 = 0;
            float Amt3 = 0;
            Debug.Log(float.TryParse(i_Cost3.text, out Cost3));
            Debug.Log(float.TryParse(i_Amt3.text, out Amt3));
            float Cost4 = 0;
            float Amt4 = 0;
            Debug.Log(float.TryParse(i_Cost4.text, out Cost4));
            Debug.Log(float.TryParse(i_Amt4.text, out Amt4));
            float Cost5 = 0;
            float Amt5 = 0;
            Debug.Log(float.TryParse(i_Cost5.text, out Cost5));
            Debug.Log(float.TryParse(i_Amt5.text, out Amt5));
            float Cost6 = 0;
            float Amt6 = 0;
            Debug.Log(float.TryParse(i_Cost6.text, out Cost6));
            Debug.Log(float.TryParse(i_Amt6.text, out Amt6));
            float Cost7 = 0;
            float Amt7 = 0;
            Debug.Log(float.TryParse(i_Cost7.text, out Cost7));
            Debug.Log(float.TryParse(i_Amt7.text, out Amt7));
            float Cost8 = 0;
            float Amt8 = 0;
            Debug.Log(float.TryParse(i_Cost8.text, out Cost8));
            Debug.Log(float.TryParse(i_Amt8.text, out Amt8));
            float RawCost = (Cost1 * Amt1) + (Cost2 * Amt2) + (Cost3 * Amt3) + (Cost4 * Amt4) + (Cost5 * Amt5) + (Cost6 * Amt6) + (Cost7 * Amt7) + (Cost8 * Amt8);
            Debug.Log(RawCost);
            float MR = 0;
            float NumItems;
            Debug.Log(float.TryParse(i_MR.text, out MR));
            float MarkupCost = RawCost * MR;
            Debug.Log(MarkupCost);
            Debug.Log(float.TryParse(i_NumItems.text, out NumItems));
            float totalCost = MarkupCost / NumItems;
            Debug.Log(totalCost);
            Price.text = totalCost.ToString();

        }
    }

    private void Quit()
    {
        Application.Quit();
    }
}
