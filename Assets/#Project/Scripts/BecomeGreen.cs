using UnityEngine;

public class BecomeGreen : MonoBehaviour
{
    // public enum Reaction
    // {
    //     Disappear,
    //     BecomeRed,
    // }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // public Reaction reaction;
        void OnTriggerEnter(Collider other) // "lorsque qqch entrer dans le collide space"
        {
        GetComponent<Renderer>().material.color = Color.greenYellow;
        }
    }