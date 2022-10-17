using UnityEngine;
using UnityEngine.UI;

namespace Pattern.FactoryMethod
{
    public class Beggar : INPC
    {
        //public GameObject beggar;
        //public Text m_MyText;
        public void Speak()
        {
            //m_MyText.text = "TBeggar: Do you have some change to spare?";
            Debug.Log("Beggar: Do you have some change to spare?");
        }
        //public void Spawn() {
        //    beggar.SetActive(false);
        //}
    }
    
}
