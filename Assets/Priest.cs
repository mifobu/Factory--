using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Priest : INPC
    {
        //public GameObject priest;
        public void Speak()
        {
            Debug.Log("Priest I am going to nail my ninety-five theses to that church door.");
        }
        //public void Spawn() {
        //    priest.SetActive(false);
        //}
    }
}
