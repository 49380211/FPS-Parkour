using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    // Start is called before the first frame update
    void update()
    {
       if (Input.GetKeyDown(KeyCode.E))
       {
          //actualizar dinero por la compra
          moneyManager.UpdateMoney(-cost);
       }
    }
}
