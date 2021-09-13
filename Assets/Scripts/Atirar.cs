using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    [SerializeField]
    private Player jogador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotz = 0;

        if (jogador.retornarMira().x > Vector2.right.x)
        {
            rotz = 0 * Mathf.Rad2Deg;
        }
        if (jogador.retornarMira().y > Vector2.up.y)
        {
            rotz = 90 * Mathf.Rad2Deg;
        }
        if (jogador.retornarMira().x < Vector2.left.x)
        {
            rotz = 210 * Mathf.Rad2Deg;
        }
        if (jogador.retornarMira().y < Vector2.down.y)
        {
            rotz = 300 * Mathf.Rad2Deg;
        }
        transform.rotation = Quaternion.Euler(0f, 0f, rotz);
    }
}
