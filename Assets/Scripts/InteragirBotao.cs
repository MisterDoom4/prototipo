using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class InteragirBotao : MonoBehaviour
{
    [SerializeField]
    private JogadorInterage jogadorInterage;

    [SerializeField]
    private UnityEvent botaoApertado;

    private bool podeExecutar;

    // Update is called once per frame
    void Update()
    {
        if (podeExecutar)
        {
            if(jogadorInterage.estaInteragindo == true)
            {
                botaoApertado.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        podeExecutar = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        podeExecutar = false;
    }
}
