using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float velocidade;

    public GameObject tiro;

    public static float X, Y;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        X = transform.position.x;
        Y = transform.position.y;

        //evento para atirar
        if (Input.GetButtonDown("A"))
        {
            Instantiate(this.tiro, new Vector2(PlayerController.X + 1f, PlayerController.Y + -0.5F), Quaternion.identity);
        }


        //movimentação na horizontal eixo x
        if (Input.GetAxis("Left Analogico Horizontal") > 0)
        {
            transform.Translate(Vector3.right * velocidade * Time.deltaTime);
        }
        if (Input.GetAxis("Left Analogico Horizontal") < 0)
        {
            transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        }

        //movimentação na Vertical eixo y
        if (Input.GetAxis("Left Analogico Vertical") > 0)
        {
            transform.Translate(Vector3.up * velocidade * Time.deltaTime);
        }
        if (Input.GetAxis("Left Analogico Vertical") < 0)
        {
            transform.Translate(Vector3.down * velocidade * Time.deltaTime);
        }
    }
}
