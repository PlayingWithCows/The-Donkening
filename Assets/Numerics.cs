using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numerics : MonoBehaviour
{

    public int pacifiers;

    private TMPro.TextMeshProUGUI pacifiersDisplay;
    // Start is called before the first frame update
    void Start()
    {
        pacifiers = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNum(int number){
    pacifiers += number;
    UpdateScore();
    }

    private void UpdateScore(){
pacifiersDisplay.text = pacifiers.ToString();
    }

}
