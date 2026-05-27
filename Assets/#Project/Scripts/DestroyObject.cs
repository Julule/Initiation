using UnityEditor.ShaderGraph;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{    void OnTriggerEnter(Collider other) // "lorsque qqch entrer dans le collide space"
    {
        Debug.Log("On est dans le trigger !");
        Destroy(gameObject);

    }
}
