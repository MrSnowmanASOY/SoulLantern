using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace playerstuffs
{
    public class keyboard_input : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.D))
            {
                VirtualInputManager.Instance.MoveRight = true;
            }
            else
            {
                VirtualInputManager.Instance.MoveRight = false;
            }

                        if (Input.GetKey(KeyCode.A))
            {
                VirtualInputManager.Instance.MoveLeft = true;
            }
            else
            {
                VirtualInputManager.Instance.MoveLeft = false;
            }
        }
    }

}
