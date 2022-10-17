using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Shopowner : INPC
    {
        //public GameObject shopowner;
        public void Speak()
        {
            Debug.Log("Shopowner: Do you wish to purchase something?");
        }
        //public void Spawn() {
        //    shopowner.SetActive(false);
        //}
    }
}