using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class NPCSpawner : MonoBehaviour
    {
        public NPCFactory m_Factory;
        private INPC m_Farmer;
        private INPC m_Beggar;
        private INPC m_Shopowner;
        private INPC m_Warrior;
        private INPC m_Priest;

        public void SpawnVillagers()
        {

            m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
            m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
            m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
            m_Warrior = m_Factory.GetNPC(NPCType.Warrior);
            m_Priest = m_Factory.GetNPC(NPCType.Priest);

            m_Beggar.Speak();
            m_Farmer.Speak();
            m_Shopowner.Speak();
            m_Warrior.Speak();
            m_Priest.Speak();
/*
            m_Beggar.Spawn();
            m_Farmer.Spawn();
            m_Shopowner.Spawn();
            m_Warrior.Spawn();
            m_Priest.Spawn();
            */
        
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag ("head");
        foreach(GameObject go in gameObjectArray)
        {
            go.SetActive (false);
        }
        }
    }
}
