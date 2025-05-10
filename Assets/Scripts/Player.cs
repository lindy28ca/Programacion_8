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
    private int da�o;
    private int durabilidad;

    public Player(int vida, int da�o, int durabilidad)
    {
        this.vida = vida;
        this.da�o = da�o;
        this.durabilidad = durabilidad;
    }

    public int Vida
    {
        get => vida;
        set => vida = value > 0 ? value : 0;
    }

    public int Da�o
    {
        get => da�o;
        set => da�o = value;
    }

    public int Durabilidad
    {
        get => durabilidad;
        set => durabilidad = value > 0 ? value : 0;
    }

    public void Atacar()
    {
        Debug.Log($"El jugador ataca infligiendo {da�o} de da�o.");
    }

    public void RecibirDanio(int cantidad)
    {
        vida -= cantidad;
        Debug.Log($"El jugador recibi� {cantidad} de da�o. Vida restante: {vida}");
    }
}