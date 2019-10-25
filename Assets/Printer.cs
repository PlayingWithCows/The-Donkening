using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printer : MonoBehaviour
{

    public float pacifProdSpeed = 1f;
    public float printerProdSpeed = 10f;
    public int productionPerCycle;
    public Numerics num;

    public bool idle = true;

    public Animator animator;

    public int product = 0;

    public int pacifCost = 10;
    public int printerCost = 1000;





    // Start is called before the first frame update
    void Start()
    {
        num = GameObject.FindObjectOfType<Numerics>();
     
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
    if(idle==true){
        Produce();
        
    }    
    }

    private void Produce(){
   idle=false;
    

if(product==0){
         
        animator.SetFloat("PrintSpeed", 1f/pacifProdSpeed);
    animator.SetTrigger("printPacifier");
}else if(product==1){
     animator.SetFloat("PrintSpeed", 1f/printerProdSpeed);
    animator.SetTrigger("printPrinter");
}

       

    }
    public void GrantNumericPacifier(){
         idle=true;
         num.AddNum(productionPerCycle);
         

    }
    public void CreatePrinter(){
        Debug.Log("printer created");
         idle=true;
         num.AddPrinter(1);
         

    }
}

