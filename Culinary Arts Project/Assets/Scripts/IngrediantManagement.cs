using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    TMP_InputField i_Cost1;
    [SerializeField]
    TMP_InputField i_Amt1;
    [SerializeField]
    TMP_InputField i_MR;
    [SerializeField]
    TMP_InputField i_NumItems;
    [SerializeField]
    TMP_Text Price;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float Cost1 = 0;
            float Amt1 = 0;
            Debug.Log(float.TryParse(i_Cost1.text, out Cost1));
            Debug.Log(float.TryParse(i_Amt1.text, out Amt1));
            float RawCost = Cost1 * Amt1;
            Debug.Log(RawCost);
            float MR = 0;
            float NumItems;
            Debug.Log(float.TryParse(i_MR.text, out MR));
            float MarkupCost = RawCost * MR;
            Debug.Log(MarkupCost);
            Debug.Log(float.TryParse(i_NumItems.text, out NumItems));
            float totalCost = MarkupCost/NumItems;
            Debug.Log(totalCost);
            Price.text = totalCost.ToString();

        }
    }
}
