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
    public bool Jogador1 = true, Venceu = false, Acabou = false, IAJogou = false;
    public int Rodada = 0, Contadorx = 0, Contadoro = 0, Empate = 0;

    // PLACAR // CONTADOR X TA COM RODADAS
    public void ContadorX()
    {
        X.text = $"Jogador 1 venceu: {Rodada}";
    }
    public void ContadorO()
    {
        O.text = $"IA venceu: {Contadoro++}";
    }
    public void Empatou()
    {
        E.text = $"Empatou: {Empate++}";
    }
    public void Update()
    {
        ContadorX();
        ContadorO();
        Empatou();
    }
    // AAAAAAAAA
    public void Rodada1()
    {
        if (Rodada == 1)
        {
            if (Q5.text == "" && Acabou == false && Jogador1 == false)
            {
                IAQ5();
            }
        }     

    }

    // Funcionamento de cada quadro

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
                IAQ0();
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ4();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                Rodada1();
                DeuVelha();
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
                IAQ0();
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ4();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                Rodada1();
                DeuVelha();
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
                IAQ0();
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ4();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                Rodada1();
                DeuVelha();
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
                IAQ0();
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ4();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                Rodada1();
                DeuVelha();
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
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ4();
                IAQ5();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                DeuVelha();
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
                IAQ0();
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ4();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                Rodada1();
                DeuVelha();
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
                IAQ0();
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ4();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                Rodada1();
                DeuVelha();
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
                IAQ0();
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ4();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                Rodada1();
                DeuVelha();
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
                IAQ0();
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ4();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                Rodada1();
                DeuVelha();
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
    // CORREÇÃO DEU VELHA //
    public void DeuVelha()
    {
        if (Rodada < 9)
        {
            Rodada++;
        }
    }


    // Botão de Reset

    public void ResetBotton()
    {
        //if (Acabou && Venceu)
            Reset();
        if (!Jogador1)
            IAQ5();

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

    // IA :)
    public void IAQ0()
    {
        // Linha 1
        if (Q1.text == "O" && Q2.text == "O" && Q3.text == "")
        {
            Q3.text = "O";
        }
        else if (Q2.text == "O" && Q3.text == "O" && Q1.text == "")
        {
            Q1.text = "O";
        }
        else if (Q1.text == "O" && Q3.text == "O" && Q2.text == "")
        {
            Q2.text = "O";
        }
        
        // Linha 2
        else if (Q4.text == "O" && Q5.text == "O" && Q6.text == "")
        {
            Q6.text = "O";
        }
        else if (Q5.text == "O" && Q6.text == "O" && Q4.text == "")
        {
            Q4.text = "O";
        }
        else if (Q4.text == "O" && Q6.text == "O" && Q5.text == "")
        {
            Q5.text = "O";
        }
        
        // Linha 3
        else if (Q7.text == "O" && Q8.text == "O" && Q9.text == "")
        {
            Q9.text = "O";
        }
        else if (Q8.text == "O" && Q9.text == "O" && Q7.text == "")
        {
            Q7.text = "O";
        }
        else if (Q7.text == "O" && Q9.text == "O" && Q8.text == "")
        {
            Q8.text = "O";
        }

        // Coluna 1
        else if (Q1.text == "O" && Q4.text == "O" && Q7.text == "")
        {
            Q7.text = "O";
        }
        else if (Q1.text == "O" && Q7.text == "O" && Q4.text == "")
        {
            Q4.text = "O";
        }
        else if (Q4.text == "O" && Q7.text == "O" && Q1.text == "")
        {
            Q1.text = "O";
        }

        // Coluna 2
        else if (Q2.text == "O" && Q5.text == "O" && Q8.text == "")
        {
            Q8.text = "O";
        }
        else if (Q5.text == "O" && Q8.text == "O" && Q2.text == "")
        {
            Q2.text = "O";
        }
        else if (Q2.text == "O" && Q8.text == "O" && Q5.text == "")
        {
            Q5.text = "O";
        }

        // Coluna 3
        else if (Q3.text == "O" && Q6.text == "O" && Q9.text == "")
        {
            Q9.text = "O";
        }
        else if (Q6.text == "O" && Q9.text == "O" && Q3.text == "")
        {
            Q3.text = "O";
        }
        else if (Q3.text == "O" && Q9.text == "O" && Q6.text == "")
        {
            Q6.text = "O";
        }

        // Diagonal 1
        else if (Q1.text == "O" && Q5.text == "O" && Q9.text == "")
        {
            Q9.text = "O";
        }
        else if (Q5.text == "O" && Q9.text == "O" && Q1.text == "")
        {
            Q1.text = "O";
        }
        else if (Q1.text == "O" && Q9.text == "O" && Q5.text == "")
        {
            Q5.text = "O";
        }

        // Diagonal 2
        else if (Q3.text == "O" && Q5.text == "O" && Q7.text == "")
        {
            Q7.text = "O";
        }
        else if (Q3.text == "O" && Q7.text == "O" && Q5.text == "")
        {
            Q5.text = "O";
        }
        else if (Q5.text == "O" && Q7.text == "O" && Q3.text == "")
        {
            Q3.text = "O";
        }
    }

    // VERIFICAÇÃO QUADRO 1 //
    public void IAQ1()
    {
        if (Q2.text == "X" && Q3.text == "X" && Acabou == false)
        {
            Q1.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else if (Q4.text == "X" && Q7.text == "X" && Acabou == false)
        {
            Q1.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else if (Q5.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q1.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
    }

    // VERIFICAÇÃO QUADRO 2 //
    public void IAQ2()
    {
        if (Q1.text == "X" && Q3.text == "X" && Acabou == false)
        {
            Q2.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else if (Q5.text == "X" && Q8.text == "X" && Acabou == false)
        {
            Q2.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
    }

    // VERIFICAÇÃO QUADRO 3 //
    public void IAQ3()
    {
        if (Q1.text == "X" && Q2.text == "X" && Acabou == false)
        {
            Q3.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else if (Q6.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q3.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else if (Q5.text == "X" && Q7.text == "X" && Acabou == false)
        {
            Q3.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
    }

    // VERIFICAÇÃO QUADRO 4 //
    public void IAQ4()
    {
        if (Q5.text == "X" && Q6.text == "X" && Acabou == false)
        {
            Q4.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else if (Q1.text == "X" && Q7.text == "X" && Acabou == false)
        {
            Q4.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
    }

    // VERIFICAÇÃO QUADRO 5 //
    public void IAQ5()
    {
        if (Q5.text == "" && Rodada == 1)
        {
            Q5.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else
        {
            float x = Random.Range(0, 4);
            if (x == 0)
            {
                Q1.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
            }
            else if (x == 1)
            {
                Q3.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
            }
            else if (x == 2)
            {
                Q7.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
            }
            else if (x == 3)
            {
                Q9.text = "O";
                Jogador1 = true;
                vezDoJogador.text = "Vez do jogador 1";
            }      
        }
    }

    // VERIFICAÇÃO QUADRO 6 //
    public void IAQ6()
    {
        if (Q4.text == "X" && Q5.text == "X" && Acabou == false)
        {
            Q6.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else if (Q3.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q6.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
    }

    // VERIFICAÇÃO QUADRO 7 //
    public void IAQ7()
    {
        if (Q1.text == "X" && Q4.text == "X" && Acabou == false)
        {
            Q7.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else if (Q8.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q7.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else if (Q3.text == "X" && Q5.text == "X" && Acabou == false)
        {
            Q7.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
    }

    // VERIFICAÇÃO QUADRO 8 //
    public void IAQ8()
    {
        if (Q2.text == "X" && Q5.text == "X" && Acabou == false)
        {
            Q8.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else if (Q7.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q8.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
    }

    // VERIFICAÇÃO QUADRO 9 //
    public void IAQ9()
    {
        if (Q7.text == "X" && Q8.text == "X" && Acabou == false)
        {
            Q9.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else if (Q3.text == "X" && Q6.text == "X" && Acabou == false)
        {
            Q9.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
        else if (Q1.text == "X" && Q5.text == "X" && Acabou == false)
        {
            Q9.text = "O";
            Jogador1 = true;
            vezDoJogador.text = "Vez do jogador 1";
        }
    }
    

    /*
     * ENtão, tem dois erros, 1 é o lado oposto, que quando vc escolhe a ia n faz nada, para resolver coloque um random/ COLOCAR CADA EXCEÇÃO JOGADA RANDOMICA NO ROUND 4
     * 2ndo erro ele ta ganhando e me bloqueando, ja n basta a minha ex? COLOCAR UM IF PARA FAZER A JOGADA SOMENTE QUANDO O JOGO N TIVER ACABADO
     */
}
