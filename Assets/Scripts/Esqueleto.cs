using UnityEngine;

public class Esqueleto : Enemigo
{
    public Esqueleto() : base("Esqueleto Guerrero", 100, 15) { }

    public override void Atacar()
    {
        Debug.Log($"{Nombre} ataca con su espada oxidada.");
    }

    public override void RecibirDanio(int cantidad)
    {
        Salud -= cantidad;
        Debug.Log($"{Nombre} recibió {cantidad} de daño. Salud restante: {Salud}");
    }

    public override void DropearItem()
    {
        Debug.Log($"{Nombre} dropea un fragmento de hueso.");
    }
}
