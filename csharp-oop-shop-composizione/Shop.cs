using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_composizione
{
    public class Shop
    {
        //ATTRIBUTI
        private string shopName;
        private string shopCity;
        private string address;
        private string houseNumber;
        private List<Product> products;

        //COSTRUTTORE
        public Shop(string shopName, string shopCity, string address, string houseNumber)
        {
            this.shopName = shopName;
            this.shopCity = shopCity;
            this.address = address;
            this.houseNumber = houseNumber;
            this.products = new List<Product>();
        }

        //GETTERS
        public string GetShopName()
        {
            return this.shopName;
        }
        public string GetShopCity()
        {
            return this.shopCity;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public string GetHouseNumber()
        {
            return this.houseNumber;
        }
        public List<Product> GetListProducts()
        {
            return this.products;
        }

        //METODO

        //Aggiungere nuovo prodotto alla lista
        public void AddNewProductToShopList(Product newProduct)
        {
            products.Add(newProduct);
        }

        //add new list of products to shop list
        public void AddNewProductListToShopList(List<Product> productList)
        {
            foreach (Product newProductList in productList)
            {
                this.products.Add(newProductList);
            }
        }

        //print shop info + products + category
        public string PrintShopInfo()
        {
            string infoShop =
            $"Nome: {this.shopName} \n" +
            $"Città: {this.shopCity} \n" +
            $"Indirizzo: {this.address} \n" +
            $"Numero civico: {this.houseNumber} \n" +
            $"Prodotti: \n";

            foreach (Product productsInList in products)
            {
            
            }

            infoShop += "\n";
            return infoShop;
        }


    }
}

