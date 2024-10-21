using UnityEngine;
using TMPro;
public class GetInputFieldValue : MonoBehaviour
{
    [SerializeField]
    TMP_InputField field;
    [SerializeField]
    TMP_InputField flour;
    [SerializeField]
    TMP_InputField flourCost;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float cost = -1;
            Debug.Log(float.TryParse(flourCost.text, out cost));
            float flourAmt = -1;
            Debug.Log(float.TryParse(flour.text, out flourAmt));
            Debug.Log(flourAmt * cost);
        }
    }
}
