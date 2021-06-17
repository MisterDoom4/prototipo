using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bau : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void abrir(bool aberto)
    {
        if(animator.GetBool("aberto") == true)
        {
            aberto = false;
        }
        animator.SetBool("aberto", aberto);
    }
    
}
