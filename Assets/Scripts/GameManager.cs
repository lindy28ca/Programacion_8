using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player player;
    private Esqueleto esqueleto;

    void Start()
    {
        player = new Player(150, 20, 10);
        esqueleto = gameObject.AddComponent<Esqueleto>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            try
            {
                Debug.Log("¡Combate iniciado!");

                if (player.Durabilidad <= 0)
                {
                    throw new ArmaSinDurabilidadException("El arma del jugador no tiene durabilidad.");
                }

                player.Atacar();
                esqueleto.RecibirDanio(player.Daño);

                player.Durabilidad -= Random.Range(1, 3);

                if (esqueleto.Salud <= 0)
                {
                    throw new PersonajeMuertoException($"{esqueleto.Nombre} ha muerto.");
                }

                esqueleto.Atacar();
                player.RecibirDanio(esqueleto.Fuerza);

                if (player.Vida <= 0)
                {
                    throw new PersonajeMuertoException("El jugador ha muerto.");
                }

                Debug.Log($"Durabilidad restante del arma del jugador: {player.Durabilidad}");

            }
            catch (PersonajeMuertoException ex)
            {
                Debug.Log(ex.Message);
            }
            catch (ArmaSinDurabilidadException ex)
            {
                Debug.Log(ex.Message);
            }
        }
    }
}