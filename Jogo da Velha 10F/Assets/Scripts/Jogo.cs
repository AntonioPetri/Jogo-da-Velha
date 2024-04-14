using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Jogo : MonoBehaviour
{
    public TextMeshProUGUI Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, vezDoJogador, X, O, E;
    public bool Jogador1 = true, Venceu = false, Acabou = false;
    public int Rodada = 0, Contadorx = 0, Contadoro = 0, Empate = 0;
    
    // Contadores
    public void ContadorX()
    {
        X.text = $"Jogador 1 venceu: {Contadorx++}";
    }   
    public void ContadorO()
    {
        O.text = $"Jogador 2 venceu: {Contadoro++}";
    }
    public void Empatou()
    {
        E.text = $"Empatou: {Empate++}";
    }
    public void Start()
    {
        ContadorX();
        ContadorO();
        Empatou();
    }

    // Funcionamento de cada quadro

    public void Quadro1()
    {
        if (Q1.text == "" && Acabou == false)
        {
            if (Jogador1)
            {
                Q1.text = "X";
                Jogador1 = false;
                vezDoJogador.text = "Vez do jogador 2";
                Rodada++;
            }
            else
            {
                Q1.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }
            Vencedor();
        }
        

    }
    
    public void Quadro2()
    {
        if (Q2.text == "" && Acabou == false)
        {
            if (Jogador1)
            {
                Q2.text = "X";
                Jogador1 = false;
                vezDoJogador.text = "Vez do jogador 2";
                Rodada++;
            }
            else
            {
                Q2.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }
            Vencedor();
        }
    }

    public void Quadro3()
    {
        if (Q3.text == "" && Acabou == false)
        {
            if (Jogador1)
            {
                Q3.text = "X";
                Jogador1 = false;
                vezDoJogador.text = "Vez do jogador 2";
                Rodada++;
            }
            else
            {
                Q3.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }
            Vencedor();
        }
    }

    public void Quadro4()
    {
        if (Q4.text == "" && Acabou == false)
        {
            if (Jogador1)
            {
                Q4.text = "X";
                Jogador1 = false;
                vezDoJogador.text = "Vez do jogador 2";
                Rodada++;
            }
            else
            {
                Q4.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }
            Vencedor();
        }
    }

    public void Quadro5()
    {
        if (Q5.text == "" && Acabou == false)
        {
            if (Jogador1)
            {
                Q5.text = "X";
                Jogador1 = false;
                vezDoJogador.text = "Vez do jogador 2";
                Rodada++;
            }
            else
            {
                Q5.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }
            Vencedor();
        }
    }

    public void Quadro6()
    {
        if (Q6.text == "" && Acabou == false)
        {
            if (Jogador1)
            {
                Q6.text = "X";
                Jogador1 = false;
                vezDoJogador.text = "Vez do jogador 2";
                Rodada++;
            }
            else
            {
                Q6.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }
            Vencedor();
        }
    }

    public void Quadro7()
    {
        if (Q7.text == "" && Acabou == false)
        {
            if (Jogador1)
            {
                Q7.text = "X";
                Jogador1 = false;
                vezDoJogador.text = "Vez do jogador 2";
                Rodada++;
            }
            else
            {
                Q7.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }
            Vencedor();
        }
    }

    public void Quadro8()
    {
        if (Q8.text == "" && Acabou == false)
        {
            if (Jogador1)
            {
                Q8.text = "X";
                Jogador1 = false;
                vezDoJogador.text = "Vez do jogador 2";
                Rodada++;
            }
            else
            {
                Q8.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }
            Vencedor();
        }
    }

    public void Quadro9()
    {
        if (Q9.text == "" && Acabou == false)
        {
            if (Jogador1)
            {
                Q9.text = "X";
                Jogador1 = false;
                vezDoJogador.text = "Vez do jogador 2";
                Rodada++;
            }
            else
            {
                Q9.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }
            Vencedor();
        }
    }

    //Quem ganhou
    
    public void Vencedor()
    { 
        // Jogador 1
        if (Q1.text == "X" && Q2.text == "X" && Q3.text == "X")
        {
            vezDoJogador.text = "O jogador 1 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorX();
        }
        if (Q4.text == "X" && Q5.text == "X" && Q6.text == "X")
        {
            vezDoJogador.text = "O jogador 1 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorX();
        }
        if (Q7.text == "X" && Q8.text == "X" && Q9.text == "X")
        {
            vezDoJogador.text = "O jogador 1 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorX();
        }
        if (Q1.text == "X" && Q4.text == "X" && Q7.text == "X")
        {
            vezDoJogador.text = "O jogador 1 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorX();

        }
        if (Q2.text == "X" && Q5.text == "X" && Q8.text == "X")
        {
            vezDoJogador.text = "O jogador 1 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorX();
        }
        if (Q3.text == "X" && Q6.text == "X" && Q9.text == "X")
        {
            vezDoJogador.text = "O jogador 1 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorX();
        }
        if (Q1.text == "X" && Q5.text == "X" && Q9.text == "X")
        {
            vezDoJogador.text = "O jogador 1 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorX();
        }
        if (Q3.text == "X" && Q5.text == "X" && Q7.text == "X")
        {
            vezDoJogador.text = "O jogador 1 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorX();
        }

        // Jogador 2

        if (Q1.text == "O" && Q2.text == "O" && Q3.text == "O")
        {
            vezDoJogador.text = "O jogador 2 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q4.text == "O" && Q5.text == "O" && Q6.text == "O")
        {
            vezDoJogador.text = "O jogador 2 venceu!";
            Venceu = true;   
            Acabou = true;
            ContadorO();
        }
        if (Q7.text == "O" && Q8.text == "O" && Q9.text == "O")
        {
            vezDoJogador.text = "O jogador 2 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q1.text == "O" && Q4.text == "O" && Q7.text == "O")
        {
            vezDoJogador.text = "O jogador 2 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q2.text == "O" && Q5.text == "O" && Q8.text == "O")
        {
            vezDoJogador.text = "O jogador 2 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q3.text == "O" && Q6.text == "O" && Q9.text == "O")
        {
            vezDoJogador.text = "O jogador 2 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q1.text == "O" && Q5.text == "O" && Q9.text == "O")
        {
            vezDoJogador.text = "O jogador 2 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q3.text == "O" && Q5.text == "O" && Q7.text == "O")
        {
            vezDoJogador.text = "O jogador 2 venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }

        // Deu velha
       
        if (Rodada == 9 && Venceu == false)
        {
            vezDoJogador.text = "Deu velha, recomece";
            Venceu = true;
            Acabou = true;
            Empatou();
        }
    }

    // Botão de Reset

    public void ResetBotton()
    {
        if (Acabou && Venceu)
            Reset();

    }

    // Reset do game
    public void Reset()
    {
        Q1.text = "";
        Q2.text = "";
        Q3.text = "";
        Q4.text = "";
        Q5.text = "";
        Q6.text = "";
        Q7.text = "";
        Q8.text = "";
        Q9.text = "";
        Acabou = false;
        Venceu = false;
        Rodada = 0;
    }
}
 