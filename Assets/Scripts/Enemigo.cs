using UnityEngine;

public abstract class Enemigo : MonoBehaviour, IAtacable, IRecibirDanio, IDropearItems
{
    [SerializeField] private string nombre;
    [SerializeField] private int salud;
    [SerializeField] private int fuerza;

    public Enemigo() { }

    public Enemigo(string nombre, int salud, int fuerza)
    {
        this.nombre = nombre;
        this.salud = salud;
        this.fuerza = fuerza;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public int Salud
    {
        get => salud;
        set => salud = value > 0 ? value : 0;
    }

    public int Fuerza
    {
        get => fuerza;
        set => fuerza = value;
    }

    public abstract void Atacar();
    public abstract void RecibirDanio(int cantidad);
    public abstract void DropearItem();
}
