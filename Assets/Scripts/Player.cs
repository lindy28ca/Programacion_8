using UnityEngine;
public interface IAtacable
{
    void Atacar();
}

public interface IRecibirDanio
{
    void RecibirDanio(int cantidad);
}

public interface IDropearItems
{
    void DropearItem();
}

public interface IAplicarBuff
{
    void AplicarBuff();
}

public class Player : MonoBehaviour, IAtacable, IRecibirDanio
{
    private int vida;
    private int daño;
    private int durabilidad;

    public Player(int vida, int daño, int durabilidad)
    {
        this.vida = vida;
        this.daño = daño;
        this.durabilidad = durabilidad;
    }

    public int Vida
    {
        get => vida;
        set => vida = value > 0 ? value : 0;
    }

    public int Daño
    {
        get => daño;
        set => daño = value;
    }

    public int Durabilidad
    {
        get => durabilidad;
        set => durabilidad = value > 0 ? value : 0;
    }

    public void Atacar()
    {
        Debug.Log($"El jugador ataca infligiendo {daño} de daño.");
    }

    public void RecibirDanio(int cantidad)
    {
        vida -= cantidad;
        Debug.Log($"El jugador recibió {cantidad} de daño. Vida restante: {vida}");
    }
}