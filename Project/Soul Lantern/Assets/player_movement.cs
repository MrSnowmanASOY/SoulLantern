using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace playerstuffs
{
    public class player_movement : MonoBehaviour
    {
        void Update()
        {
            if (VirtualInputManager.Instance.MoveRight)
            {
                this.gameObject.transform.Translate(Vector3.forward * 10f * Time.deltaTime);
            }

            if (VirtualInputManager.Instance.MoveLeft)
            {
                this.gameObject.transform.Translate(-Vector3.forward * 10f * Time.deltaTime);
            }
        }
    }

}