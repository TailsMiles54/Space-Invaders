using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
   public GameObject ShopPanel, ShopMenu, Storage;
   private Storage ShopStorage;
   private Vector3 shopPanelTransform;

   public void Start()
   {
      ShopStorage = Storage.GetComponent<Storage>();
      LoadShop();
   }

   void LoadShop()
   {
      shopPanelTransform = ShopMenu.transform.position + new Vector3(0, 500, 0);
      for (int i = 0; i < ShopStorage.ShopShipsStorage.Length; i++)
      {
         GameObject ShopElement = Instantiate(ShopPanel);
         ShopElement.transform.SetParent(ShopMenu.transform,false);
         ShopElement.transform.position = shopPanelTransform;
         if (ShopStorage.ShopShipsStorage[i].ShopShipsUnlock == false){
            ShopElement.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Купить";
         }
         if (ShopStorage.ShopShipsStorage[i].ShopShipsUnlock == true) {
            ShopElement.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Выбрать";
         }
         
         ShopElement.transform.GetChild(1).GetComponent<Text>().text = ShopStorage.ShopShipsStorage[i].ShopShipsName;
         ShopElement.transform.GetChild(2).GetComponent<Text>().text = "Цена: " + ShopStorage.ShopShipsStorage[i].ShopShipsCost;
         ShopElement.transform.GetChild(3).GetComponent<Image>().sprite = ShopStorage.ShopShipsStorage[i].ShopShipsPrefab.GetComponent<SpriteRenderer>().sprite;
         
         shopPanelTransform -= new Vector3(0, 600, 0);
      }
   }
}
