using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printer : MonoBehaviour
{

    public float printSpeed;
    public int productionPerCycle;
    public Numerics num;

    private bool idle = true;

    public Animator animator;

    public int product = 0;


private float timeSinceLastCycle;


    // Start is called before the first frame update
    void Start()
    {
        num = GameObject.FindObjectOfType<Numerics>();
        timeSinceLastCycle=Time.time;
        
    }
    // Update is called once per frame
    void Update()
    {
    if(timeSinceLastCycle < Time.time+printSpeed && idle==true){
        ProducePacifier();
        timeSinceLastCycle = Time.time;
    }    
    }

    private void ProducePacifier(){
        idle=false;
animator.SetTrigger(product);
animator.speed = printSpeed;
       

    }
    public void GrantNumeric(){
         num.AddNum(productionPerCycle);
         idle=true;

    }

}
