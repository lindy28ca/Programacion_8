using UnityEngine;

public class Ogro : Enemigo
{
    public Ogro() : base("Ogro Salvaje", 150, 20) { }

    public override void Atacar()
    {
        Debug.Log($"{Nombre} lanza un golpe devastador.");
    }

    public override void RecibirDanio(int cantidad)
    {
        Salud -= cantidad;
        Debug.Log($"{Nombre} recibió {cantidad} de daño. Salud restante: {Salud}");
    }

    public override void DropearItem()
    {
        Debug.Log($"{Nombre} dropea una piedra mágica.");
    }
}
