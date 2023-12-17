using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    private List<Key.KeyType> keyList;

    private void Awake()
    {
        keyList = new List<Key.KeyType>();
    }

    public void AddKey(Key.KeyType keyType) //function to add a key
    {
        keyList.Add(keyType);
    }

    public void RemoveKey(Key.KeyType keyType) //function to remove a key
    {
        keyList.Add(keyType);
    }

    public void ContainsKey(Key.KeyType keyType) //fucntion to check if we have the key
    {
        keyList.Add(keyType);
    }

    public bool Contains1Key(Key.KeyType keyType) //returns true or false vaule.
    {
        return keyList.Contains(keyType);
    }


    private void OnTriggerEnter2D(Collider2D collider) //to interact with our key
    {
        Key key = collider.GetComponent<Key>();
        if (key != null) //if key value is not null, then it means that we have touched the key
        {
            AddKey(key.GetKeyType()); //after the touch the key will be added
            Destroy(key.gameObject); //and with this code the key will be destroyed.

            KeyDoor keyDoor = collider.GetComponent<KeyDoor>();
            if (keyDoor != null)   //if player has the key and collides with the door (we applied the keyholder scirpt to the player)
            {
                if (Contains1Key(keyDoor.GetKeyType()))
                { //if we contain the key
                    RemoveKey(keyDoor.GetKeyType()); //remove the keydoor.GetKeyType
                    keyDoor.OpenDoor(); //then the door will open "we set the gameObject.SetActive(false); in the KeyDoor scirpt.

                }
            }

        }
    }
}
        
    


