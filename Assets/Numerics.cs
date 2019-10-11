using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numerics : MonoBehaviour
{

    public int pacifiers;
    public int printers;
    public int resources;

    public TMPro.TextMeshProUGUI pacifiersDisplay;
    // Start is called before the first frame update
    void Start()
    {
        resources = 100000;
        pacifiers = 0;
        printers = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNum(int number){
    pacifiers += number;
    UpdateScore();
    }
      public void AddPrinter(int number){
    printers += number;
    UpdateScore();
    }

    private void UpdateScore(){
pacifiersDisplay.text = pacifiers.ToString();
    }

}