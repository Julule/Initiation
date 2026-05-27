using Mono.Cecil.Cil;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
public float RotationSpeed = 90;
public Space CoordRef; // pour rendre l'enum accessible dans Unity

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // myTransform = gameObject.GetComponent<Transform>();
        // //équivalent à :
        // transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);
    }

    // Update is called once per frame
    void Update()
    {
    transform.Rotate(0, RotationSpeed * Time.deltaTime, 0, CoordRef); // donc ici Coordref est une enum de type Space, donc world/self sont ses deux options

    } //Update close
}
