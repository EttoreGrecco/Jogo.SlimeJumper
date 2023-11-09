using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsButton : MonoBehaviour  
{

    public Button botao;
    public GameObject OptionsBox;
    public GameObject Menu;

    
    public void Awake()
    {
        botao.onClick.AddListener(Click);
    }

    
    public void Click()
    {
        OptionsBox.SetActive(true);
        Menu.SetActive(false);
    }
}
