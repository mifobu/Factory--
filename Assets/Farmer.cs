using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Farmer : INPC
    {
        //public GameObject farmer;
        public void Speak()
        {
            Debug.Log("Farmer: You reap what you sow!");
        }
        //public void Spawn() {
        //    farmer.SetActive(false);
        //}
    }
}
