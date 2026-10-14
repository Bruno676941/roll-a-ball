using UnityEngine;

public class GirarDisco : MonoBehaviour
{
    public float velocidade = 100f;

    void Update()
    {
        transform.Rotate(0, velocidade * Time.deltaTime, 0);
    }
}
