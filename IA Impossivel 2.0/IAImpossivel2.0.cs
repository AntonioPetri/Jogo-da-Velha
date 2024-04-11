using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Security.Cryptography;
using UnityEngine.UIElements;

public class IAImpossivel : MonoBehaviour
{
    public TextMeshProUGUI Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, vezDoJogador, X, O, E;
    public bool Jogador1 = true, Venceu = false, Acabou = false;
    public int Rodada = 0, Contadorx = 0, Contadoro = 0, Empate = 0;

    // PLACAR //
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
    // AAAAAAAAA


    // FUNCIONAMENTO CADA QUADRO //

    public void Quadro1()
    {
        if (Q1.text == "" && Acabou == false && Jogador1)
        {
            Q1.text = "X";
            Jogador1 = false;
            vezDoJogador.text = "Vez do jogador 2";
            Rodada++;           
            if (Jogador1 == false && Acabou == false)
            {
                IA();
            }
            Vencedor();
        }

    }

    public void Quadro2()
    {
        if (Q2.text == "" && Acabou == false && Jogador1)
        {
            Q2.text = "X";
            Jogador1 = false;
            vezDoJogador.text = "Vez do jogador 2";
            Rodada++;
            if (Jogador1 == false && Acabou == false)
            {
                IA();
            }
            Vencedor();
        }
    }

    public void Quadro3()
    {
        if (Q3.text == "" && Acabou == false && Jogador1)
        {
            Q3.text = "X";
            Jogador1 = false;
            vezDoJogador.text = "Vez do jogador 2";
            Rodada++;
            if (Jogador1 == false && Acabou == false)
            {
                IA();
            }
            Vencedor();
        }       
    }

    public void Quadro4()
    {
        if (Q4.text == "" && Acabou == false && Jogador1)
        {
            Q4.text = "X";
            Jogador1 = false;
            Rodada++;
            if (Jogador1 == false && Acabou == false)
            {
                IA();
            }
            Vencedor();
        }
    }

    public void Quadro5()
    {
        if (Q5.text == "" && Acabou == false && Jogador1)
        {
            Q5.text = "X";
            Jogador1 = false;
            Rodada++;
            if (Jogador1 == false && Acabou == false)
            {
                IA();
            }
            Vencedor();
        }
    }

    public void Quadro6()
    {
        if (Q6.text == "" && Acabou == false && Jogador1)
        {
            Q6.text = "X";
            Jogador1 = false;
            Rodada++;
            if (Jogador1 == false && Acabou == false)
            {
                IA();
            }
            Vencedor();
        }
    }

    public void Quadro7()
    {
        if (Q7.text == "" && Acabou == false && Jogador1)
        {
            Q7.text = "X";
            Jogador1 = false;
            Rodada++;
            if (Jogador1 == false && Acabou == false)
            {
                IA();
            }
            Vencedor();
        }
    }

    public void Quadro8()
    {
        if (Q8.text == "" && Acabou == false && Jogador1)
        {
            Q8.text = "X";
            Jogador1 = false;
            Rodada++;
            if (Jogador1 == false && Acabou == false)
            {
                IA();
            }
            Vencedor();
        }
    }

    public void Quadro9()
    {
        if (Q9.text == "" && Acabou == false && Jogador1)
        {
            Q9.text = "X";
            Jogador1 = false;
            vezDoJogador.text = "Vez do jogador 2";
            Rodada++;
            if (Jogador1 == false && Acabou == false)
            {
                IA();
            }
            Vencedor();
        }
    }

    // VERIFICA��O QUEM GANHOU //
    
    public void Vencedor()
    {
        // JOGADOR 1 //
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

        // IA VENCEU //

        if (Q1.text == "O" && Q2.text == "O" && Q3.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q4.text == "O" && Q5.text == "O" && Q6.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q7.text == "O" && Q8.text == "O" && Q9.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q1.text == "O" && Q4.text == "O" && Q7.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q2.text == "O" && Q5.text == "O" && Q8.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q3.text == "O" && Q6.text == "O" && Q9.text == "O")
        {
            vezDoJogador.text = "A IA   venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q1.text == "O" && Q5.text == "O" && Q9.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }
        if (Q3.text == "O" && Q5.text == "O" && Q7.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            ContadorO();
        }

        // DEU VELHA //

        if (Rodada == 9 && Venceu == false)
        {
            vezDoJogador.text = "Deu velha, recomece";
            Venceu = true;
            Acabou = true;
            Empatou();
        }

        
    }
    

    // BOT�O DE RESET //

    public void ResetBotton()
    {
        //if (Acabou && Venceu) <-------------------------------------
            Reset();

    }

    // RESET DO GAME //
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

    // IA >:(
    public void IA()
    {
        // IA QUER GANHAR //
        // Linha 1
        if (Q1.text == "O" && Q2.text == "O" && Q3.text == "")
        {
            Q3.text = "O";
            Rodada++;
        }
        else if (Q2.text == "O" && Q3.text == "O" && Q1.text == "")
        {
            Q1.text = "O";
            Rodada++;
        }
        else if (Q1.text == "O" && Q3.text == "O" && Q2.text == "")
        {
            Q2.text = "O";
            Rodada++;
        }
        
        // Linha 2
        else if (Q4.text == "O" && Q5.text == "O" && Q6.text == "")
        {
            Q6.text = "O";
            Rodada++;
        }
        else if (Q5.text == "O" && Q6.text == "O" && Q4.text == "")
        {
            Q4.text = "O";
            Rodada++;
        }
        else if (Q4.text == "O" && Q6.text == "O" && Q5.text == "")
        {
            Q5.text = "O";
            Rodada++;
        }
        
        // Linha 3
        else if (Q7.text == "O" && Q8.text == "O" && Q9.text == "")
        {
            Q9.text = "O";
            Rodada++;
        }
        else if (Q8.text == "O" && Q9.text == "O" && Q7.text == "")
        {
            Q7.text = "O";
            Rodada++;
        }
        else if (Q7.text == "O" && Q9.text == "O" && Q8.text == "")
        {
            Q8.text = "O";
            Rodada++;
        }

        // Coluna 1
        else if (Q1.text == "O" && Q4.text == "O" && Q7.text == "")
        {
            Q7.text = "O";
            Rodada++;
        }
        else if (Q1.text == "O" && Q7.text == "O" && Q4.text == "")
        {
            Q4.text = "O";
            Rodada++;
        }
        else if (Q4.text == "O" && Q7.text == "O" && Q1.text == "")
        {
            Q1.text = "O";
            Rodada++;
        }

        // Coluna 2
        else if (Q2.text == "O" && Q5.text == "O" && Q8.text == "")
        {
            Q8.text = "O";
            Rodada++;
        }
        else if (Q5.text == "O" && Q8.text == "O" && Q2.text == "")
        {
            Q2.text = "O";
            Rodada++;
        }
        else if (Q2.text == "O" && Q8.text == "O" && Q5.text == "")
        {
            Q5.text = "O";
            Rodada++;
        }

        // Coluna 3
        else if (Q3.text == "O" && Q6.text == "O" && Q9.text == "")
        {
            Q9.text = "O";
            Rodada++;
        }
        else if (Q6.text == "O" && Q9.text == "O" && Q3.text == "")
        {
            Q3.text = "O";
            Rodada++;
        }
        else if (Q3.text == "O" && Q9.text == "O" && Q6.text == "")
        {
            Q6.text = "O";
            Rodada++;
        }

        // Diagonal 1
        else if (Q1.text == "O" && Q5.text == "O" && Q9.text == "")
        {
            Q9.text = "O";
            Rodada++;
        }
        else if (Q5.text == "O" && Q9.text == "O" && Q1.text == "")
        {
            Q1.text = "O";
            Rodada++;
        }
        else if (Q1.text == "O" && Q9.text == "O" && Q5.text == "")
        {
            Q5.text = "O";
            Rodada++;
        }

        // Diagonal 2
        else if (Q3.text == "O" && Q5.text == "O" && Q7.text == "")
        {
            Q7.text = "O";
            Rodada++;
        }
        else if (Q3.text == "O" && Q7.text == "O" && Q5.text == "")
        {
            Q5.text = "O";
            Rodada++;
        }
        else if (Q5.text == "O" && Q7.text == "O" && Q3.text == "")
        {
            Q3.text = "O";
            Rodada++;
        }

        // VERIFICA��O QUADRO 1 //
        if (Q2.text == "X" && Q3.text == "X" && Acabou == false)
        {
            Q1.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else if (Q4.text == "X" && Q7.text == "X" && Acabou == false)
        {
            Q1.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else if (Q5.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q1.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
    
        // VERIFICA��O QUADRO 2 //
        if (Q1.text == "X" && Q3.text == "X" && Acabou == false)
        {
            Q2.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else if (Q5.text == "X" && Q8.text == "X" && Acabou == false)
        {
            Q2.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }        

        // VERIFICA��O QUADRO 3 //
        if (Q1.text == "X" && Q2.text == "X" && Acabou == false)
        {
            Q3.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else if (Q6.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q3.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else if (Q5.text == "X" && Q7.text == "X" && Acabou == false)
        {
            Q3.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
  
        // VERIFICA��O QUADRO 4 //
        if (Q5.text == "X" && Q6.text == "X" && Acabou == false)
        {
            Q4.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else if (Q1.text == "X" && Q7.text == "X" && Acabou == false)
        {
            Q4.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }

        // VERIFICA��O QUADRO 5 //
        if (Q5.text == "" && Rodada == 1)
        {
            Q5.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else
        {
            float x = Random.Range(0, 4);
            if (x == 0)
            {
                Q1.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }
            else if (x == 1)
            {
                Q3.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }
            else if (x == 2)
            {
                Q7.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }
            else if (x == 3)
            {
                Q9.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
                Rodada++;
            }      
        }

        // VERIFICA��O QUADRO 6 //
        if (Q4.text == "X" && Q5.text == "X" && Acabou == false)
        {
            Q6.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else if (Q3.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q6.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }

        // VERIFICA��O QUADRO 7 //
        if (Q1.text == "X" && Q4.text == "X" && Acabou == false)
        {
            Q7.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else if (Q8.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q7.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else if (Q3.text == "X" && Q5.text == "X" && Acabou == false)
        {
            Q7.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }

        // VERIFICA��O QUADRO 8 //
        if (Q2.text == "X" && Q5.text == "X" && Acabou == false)
        {
            Q8.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else if (Q7.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q8.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }

        // VERIFICA��O QUADRO 9 //
        if (Q7.text == "X" && Q8.text == "X" && Acabou == false)
        {
            Q9.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else if (Q3.text == "X" && Q6.text == "X" && Acabou == false)
        {
            Q9.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
        else if (Q1.text == "X" && Q5.text == "X" && Acabou == false)
        {
            Q9.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
            Rodada++;
        }
    }

    /*
     * ENt�o, tem dois erros, 1 � o lado oposto, que quando vc escolhe a ia n faz nada, para resolver coloque um random/ COLOCAR CADA EXCE��O JOGADA RANDOMICA NO ROUND 4
     * 2ndo erro ele ta ganhando e me bloqueando, ja n basta a minha ex? COLOCAR UM IF PARA FAZER A JOGADA SOMENTE QUANDO O JOGO N TIVER ACABADO
     * 3icero n ta dando velha, so novinha / O PROBLEMA PROVAVELMENTE � AS RODADAS N�O EST�O AUMENTANDO, TROCAR CONTADOR PARA DEBUGGAR
     */
}
