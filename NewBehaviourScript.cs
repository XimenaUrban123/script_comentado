using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
   
   //variable asociada al componente TextMeshPro. al cambiar texto.text cambiara el texto que se ve en Unity
   public TextMeshProUGUI texto;
   
   //variable de tipo entero con la cual se cambiara condicionalmente el valor de texto.text en pasos posteriores
   public int acelerador;

   //variable de tipo string con la cual se cambiara condicionalmente el valor de texto.text en pasos posteriores
   public string freno;


    // Start is called before the first frame update
    void Start()
    {
        //establecimiento de texto inicial para el componente TextMeshPro
        texto.text="Acelera";
    }

    // Update is called once per frame
    void Update()
    {
        //condicional que en caso de presionar la tecla W se procedera con la ejecucion de las instrucciones que contiene 
        if (Input.GetKey(KeyCode.W))
        {
            //se aumenta en 1 el valor de la variable acelerador. acelerador++ => acelerador=acelerador + 1
            acelerador++;

            //condicional. En caso de que la variable acelerador sea mayor o igual a 200 se ejecutaran sus instrucciones 
            if(acelerador >= 200){

                //se establece el valor de la variable acelerador en 200 
                acelerador=200;

                //se asigna a texto.text el valor de la variable acelerador, pero antes cambiando su tipo a string                               
                texto.text = acelerador.ToString();
            }
           
        }
        //condicional. En caso  de que no se este presionando la tecla W se ejecutaran sus instrucciones 
        if (Input.GetKeyUp(KeyCode.W))
        {
            //se asiga el valor de la variable freno a texto.text                                                                                            
            texto.text=freno;
        }
         
          //texto.text= acelerador.ToString();
    }
}
