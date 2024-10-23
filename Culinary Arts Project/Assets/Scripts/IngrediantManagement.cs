using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    GameObject layout;
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

    }

    public void calculate()
    {
        float cost = 0;
        float amt = 0;
        GameObject[] costs = GameObject.FindGameObjectsWithTag("cost");
        GameObject[] quantity = GameObject.FindGameObjectsWithTag("quantity");
        for(int i = 0; i < costs.Length; i++)
        {
            float temp1 = 0;
            float.TryParse(costs[i].GetComponent<TMP_InputField>().text, out temp1);
            cost += temp1;
        }
        for(int i = 0;i < quantity.Length; i++)
        {
            float temp2 = 0;
            float.TryParse(quantity[i].GetComponent<TMP_InputField>().text, out temp2);
            amt += temp2;
        }
        float RawCost = cost * amt;
        Debug.Log(RawCost);
        float MR = 0;
        Debug.Log(float.TryParse(i_MR.text, out MR));
        float MarkupCost = RawCost * MR;
        Debug.Log(MarkupCost);
        float NumItems;
        Debug.Log(float.TryParse(i_NumItems.text, out NumItems));
        float totalCost = MarkupCost / NumItems;
        Debug.Log(totalCost);
        Price.text = totalCost.ToString();
    }

    public void add()
    {
        GameObject foo = Instantiate(prefab);
        foo.transform.parent = layout.transform;
        
    }

    public void quit()
    {
        Application.Quit();
    }
}
