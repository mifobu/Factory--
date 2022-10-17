using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Warrior : INPC
    {
        //public GameObject warrior;
        public void Speak()
        {
            Debug.Log("Warrior: Aurelian was the best commander I ever had...");
        }
        //public void Spawn() {
        //    warrior.SetActive(false);
        //}
    }
}
