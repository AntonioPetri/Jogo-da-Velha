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

    // PLACAR // 
    public void ContadorX()
    {
        X.text = $"Jogador 1 venceu: {Contadorx++}";
    }
    public void ContadorO()
    {
        O.text = $"IA venceu: {Contadoro++}";
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
    // FUNCIONAMENTO DE CADA QUADRO //

    public void Quadro1()
    {
        if (Q1.text == "" && Acabou == false && Jogador1)
        {
            Q1.text = "X";
            Jogador1 = false;
            Rodada++;           
            if (Jogador1 == false && Acabou == false)
            {
                IAQ0();
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ4();
                IAQ5();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                RandomChoose();
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
            Rodada++;
            if (Jogador1 == false && Acabou == false)
            {
                IAQ0();
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ5();
                IAQ4();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                RandomChoose();
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
            Rodada++;
            if (Jogador1 == false && Acabou == false)
            {
                IAQ0();
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ4();
                IAQ5();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                RandomChoose();
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
                IAQ5();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                RandomChoose();
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
                IAQ5();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                RandomChoose();
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
                IAQ5();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                RandomChoose();
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
                IAQ5();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                RandomChoose();
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
            Rodada++;
            if (Jogador1 == false && Acabou == false)
            {
                IAQ0();
                IAQ1();
                IAQ2();
                IAQ3();
                IAQ4();
                IAQ5();
                IAQ6();
                IAQ7();
                IAQ8();
                IAQ9();
                RandomChoose();
                DeuVelha();
            }
            Vencedor();
        }
    }

    // QUEM GANHOU //
    
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

        // IA venceu

        if (Q1.text == "O" && Q2.text == "O" && Q3.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            Jogador1 = true;
            ContadorO();
        }
        if (Q4.text == "O" && Q5.text == "O" && Q6.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            Jogador1 = true;
            ContadorO();
        }
        if (Q7.text == "O" && Q8.text == "O" && Q9.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            Jogador1 = true;
            ContadorO();
        }
        if (Q1.text == "O" && Q4.text == "O" && Q7.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            Jogador1 = true;
            ContadorO();
        }
        if (Q2.text == "O" && Q5.text == "O" && Q8.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            Jogador1 = true;
            ContadorO();
        }
        if (Q3.text == "O" && Q6.text == "O" && Q9.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            Jogador1 = true;
            ContadorO();
        }
        if (Q1.text == "O" && Q5.text == "O" && Q9.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            Jogador1 = true;
            ContadorO();
        }
        if (Q3.text == "O" && Q5.text == "O" && Q7.text == "O")
        {
            vezDoJogador.text = "A IA venceu!";
            Venceu = true;
            Acabou = true;
            Jogador1 = true;
            ContadorO();
        }

        // DEU VELHA //

        if (Rodada == 9 && !Venceu && Jogador1)
        {
            vezDoJogador.text = "Deu velha, recomece";
            Venceu = true;
            Acabou = true;
            Jogador1 = false;
            Empatou();
        }
        if (Rodada == 9 && !Venceu && !Jogador1)
        {
            vezDoJogador.text = "Deu velha, recomece";
            Venceu = true;
            Acabou = true;
            Jogador1 = true;   
            Empatou();
        }


    }
    // CORREÇÃO DEU VELHA //
    public void DeuVelha()
    {
        if (Rodada < 9 && Jogador1)
            Rodada++;
    }


    // Botão de Reset

    public void ResetBotton()
    {
        if (Acabou && Venceu) //<------------------------------ Contra a IA não faz diferença
        { 
            Reset();
            vezDoJogador.text = "Vez do jogador 1";
        }
        if (!Jogador1)
        {
            IAQ5();
            vezDoJogador.text = "Vez do jogador 1";
        }
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
        // VONTADE DE GANHAR //
        // Linha 1
        if (Q1.text == "O" && Q2.text == "O" && Q3.text == "")
        {
            Q3.text = "O";
            Acabou = true;
        }
        else if (Q2.text == "O" && Q3.text == "O" && Q1.text == "")
        {
            Q1.text = "O";
            Acabou = true;
        }
        else if (Q1.text == "O" && Q3.text == "O" && Q2.text == "")
        {
            Q2.text = "O";
            Acabou = true;
        }
        
        // Linha 2
        else if (Q4.text == "O" && Q5.text == "O" && Q6.text == "")
        {
            Q6.text = "O";
            Acabou = true;
        }
        else if (Q5.text == "O" && Q6.text == "O" && Q4.text == "")
        {
            Q4.text = "O";
            Acabou = true;
        }
        else if (Q4.text == "O" && Q6.text == "O" && Q5.text == "")
        {
            Q5.text = "O";
            Acabou = true;
        }
        
        // Linha 3
        else if (Q7.text == "O" && Q8.text == "O" && Q9.text == "")
        {
            Q9.text = "O";
            Acabou = true;
        }
        else if (Q8.text == "O" && Q9.text == "O" && Q7.text == "")
        {
            Q7.text = "O";
            Acabou = true;
        }
        else if (Q7.text == "O" && Q9.text == "O" && Q8.text == "")
        {
            Q8.text = "O";
            Acabou = true;
        }

        // Coluna 1
        else if (Q1.text == "O" && Q4.text == "O" && Q7.text == "")
        {
            Q7.text = "O";
            Acabou = true;
        }
        else if (Q1.text == "O" && Q7.text == "O" && Q4.text == "")
        {
            Q4.text = "O";
            Acabou = true;
        }
        else if (Q4.text == "O" && Q7.text == "O" && Q1.text == "")
        {
            Q1.text = "O";
            Acabou = true;
        }

        // Coluna 2
        else if (Q2.text == "O" && Q5.text == "O" && Q8.text == "")
        {
            Q8.text = "O";
            Acabou = true;
        }
        else if (Q5.text == "O" && Q8.text == "O" && Q2.text == "")
        {
            Q2.text = "O";
            Acabou = true;
        }
        else if (Q2.text == "O" && Q8.text == "O" && Q5.text == "")
        {
            Q5.text = "O";
            Acabou = true;
        }

        // Coluna 3
        else if (Q3.text == "O" && Q6.text == "O" && Q9.text == "")
        {
            Q9.text = "O";
            Acabou = true;
        }
        else if (Q6.text == "O" && Q9.text == "O" && Q3.text == "")
        {
            Q3.text = "O";
            Acabou = true;
        }
        else if (Q3.text == "O" && Q9.text == "O" && Q6.text == "")
        {
            Q6.text = "O";
            Acabou = true;
        }

        // Diagonal 1
        else if (Q1.text == "O" && Q5.text == "O" && Q9.text == "")
        {
            Q9.text = "O";
            Acabou = true;
        }
        else if (Q5.text == "O" && Q9.text == "O" && Q1.text == "")
        {
            Q1.text = "O";
            Acabou = true;
        }
        else if (Q1.text == "O" && Q9.text == "O" && Q5.text == "")
        {
            Q5.text = "O";
            Acabou = true;
        }

        // Diagonal 2
        else if (Q3.text == "O" && Q5.text == "O" && Q7.text == "")
        {
            Q7.text = "O";
            Acabou = true;
        }
        else if (Q3.text == "O" && Q7.text == "O" && Q5.text == "")
        {
            Q5.text = "O";
            Acabou = true;
        }
        else if (Q5.text == "O" && Q7.text == "O" && Q3.text == "")
        {
            Q3.text = "O";
            Acabou = true;
        }
    }

    // VERIFICAÇÃO QUADRO 1 //
    public void IAQ1()
    {
        if (Q2.text == "X" && Q3.text == "X" && Acabou == false)
        {
            Q1.text = "O";
            Jogador1 = true;
        }
        else if (Q4.text == "X" && Q7.text == "X" && Acabou == false)
        {
            Q1.text = "O";
            Jogador1 = true;
        }
        else if (Q5.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q1.text = "O";
            Jogador1 = true;
        }
    }

    // VERIFICAÇÃO QUADRO 2 //
    public void IAQ2()
    {
        if (Q1.text == "X" && Q3.text == "X" && Acabou == false)
        {
            Q2.text = "O";
            Jogador1 = true;
        }
        else if (Q5.text == "X" && Q8.text == "X" && Acabou == false)
        {
            Q2.text = "O";
            Jogador1 = true;
        }
    }

    // VERIFICAÇÃO QUADRO 3 //
    public void IAQ3()
    {
        if (Q1.text == "X" && Q2.text == "X" && Acabou == false)
        {
            Q3.text = "O";
            Jogador1 = true;
        }
        else if (Q6.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q3.text = "O";
            Jogador1 = true;
        }
        else if (Q5.text == "X" && Q7.text == "X" && Acabou == false)
        {
            Q3.text = "O";
            Jogador1 = true;
        }
    }

    // VERIFICAÇÃO QUADRO 4 //
    public void IAQ4()
    {
        if (Q5.text == "X" && Q6.text == "X" && Acabou == false)
        {
            Q4.text = "O";
            Jogador1 = true;
        }
        else if (Q1.text == "X" && Q7.text == "X" && Acabou == false)
        {
            Q4.text = "O";
            Jogador1 = true;
        }
    }

    // VERIFICAÇÃO QUADRO 5 //
    public void IAQ5()
    {
        if (!Jogador1 && Rodada == 0)
        {
            Q5.text = "O";
            Jogador1 = true;
            Rodada++;
        }
        if (Q5.text == "" && Rodada == 1)
        {
            Q5.text = "O";
            Jogador1 = true;
        }
        else if (Q5.text == "X" && Rodada == 1)
        {
            float x = Random.Range(0, 4);
            if (x == 0)
            {
                Q1.text = "O";
                Jogador1 = true;
            }
            else if (x == 1)
            {
                Q3.text = "O";
                Jogador1 = true;
            }
            else if (x == 2)
            {
                Q7.text = "O";
                Jogador1 = true;
            }
            else if (x == 3)
            {
                Q9.text = "O";
                Jogador1 = true;
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
        }
        else if (Q3.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q6.text = "O";
            Jogador1 = true;
        }
    }

    // VERIFICAÇÃO QUADRO 7 //
    public void IAQ7()
    {
        if (Q1.text == "X" && Q4.text == "X" && Acabou == false)
        {
            Q7.text = "O";
            Jogador1 = true;
        }
        else if (Q8.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q7.text = "O";
            Jogador1 = true;
        }
        else if (Q3.text == "X" && Q5.text == "X" && Acabou == false)
        {
            Q7.text = "O";
            Jogador1 = true;
        }
    }

    // VERIFICAÇÃO QUADRO 8 //
    public void IAQ8()
    {
        if (Q2.text == "X" && Q5.text == "X" && Acabou == false)
        {
            Q8.text = "O";
            Jogador1 = true;
        }
        else if (Q7.text == "X" && Q9.text == "X" && Acabou == false)
        {
            Q8.text = "O";
            Jogador1 = true;
        }
    }

    // VERIFICAÇÃO QUADRO 9 //
    public void IAQ9()
    {
        if (Q7.text == "X" && Q8.text == "X" && Acabou == false)
        {
            Q9.text = "O";
            Jogador1 = true;
        }
        else if (Q3.text == "X" && Q6.text == "X" && Acabou == false)
        {
            Q9.text = "O";
            Jogador1 = true;
        }
        else if (Q1.text == "X" && Q5.text == "X" && Acabou == false)
        {
            Q9.text = "O";
            Jogador1 = true;
        }
    }

    // ESCOLHA ALEATÓRIA PARA A IA ENTENDER O QUE FAZER // 

    public void RandomChoose()
    {
        // IA COMEÇA //
        // CANTO
        if (Rodada == 2)
        {
            float s = Random.Range(0, 3);
            if (Q5.text == "O" && Q1.text == "X")
            {
                if (s == 0)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (s == 1)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
                if (s == 2)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q3.text == "X")
            {
                if (s == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (s == 1)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
                if (s == 2)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q7.text == "X")
            {
                if (s == 0)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (s == 1)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (s == 2)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q9.text == "X")
            {
                if (s == 0)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (s == 1)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
                if (s == 2)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
            }
        }

        // CRUZ
        if (Rodada == 2)
        {
            float k = Random.Range(0, 4);
            if (Q5.text == "O" && Q2.text == "X")
            {
                if (k == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (k == 1)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (k == 2)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
                if (k == 3)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q4.text == "X")
            {
                if (k == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (k == 1)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (k == 2)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
                if (k == 3)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q6.text == "X")
            {
                if (k == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (k == 1)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (k == 2)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
                if (k == 3)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q8.text == "X")
            {
                if (k == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (k == 1)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (k == 2)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
                if (k == 3)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
        }

        // IA COMEÇA RODADA 8 // <---------------------------
        if (Rodada == 6)
        {
            float e = Random.Range(0, 2);
            if (Q5.text == "O" && Q3.text == "O" && Q4.text == "O" && Q9.text == "" && Q2.text == "" && Q8.text == "")
            {
                if (e == 0)
                {
                    Q2.text = "O";
                    Jogador1 = true;
                }
                if (e == 1)
                {
                    Q8.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q9.text == "O" && Q4.text == "O" && Q3.text == "" && Q2.text == "" && Q8.text == "")
            {
                if (e == 0)
                {
                    Q2.text = "O";
                    Jogador1 = true;
                }
                if (e == 1)
                {
                    Q8.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q1.text == "O" && Q6.text == "O" && Q7.text == "" && Q2.text == "" && Q8.text == "")
            {
                if (e == 0)
                {
                    Q2.text = "O";
                    Jogador1 = true;
                }
                if (e == 1)
                {
                    Q8.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q7.text == "O" && Q6.text == "O" && Q1.text == "" && Q2.text == "" && Q8.text == "")
            {
                if (e == 0)
                {
                    Q2.text = "O";
                    Jogador1 = true;
                }
                if (e == 1)
                {
                    Q8.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q7.text == "O"  && Q2.text == "O" && Q9.text == "" && Q4.text == "" && Q6.text == "")
            {
                if (e == 0)
                {
                    Q4.text = "O";
                    Jogador1 = true;
                }
                if (e == 1)
                {
                    Q6.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q9.text == "O" && Q2.text == "O" && Q7.text == "" && Q4.text == "" && Q6.text == "")
            {
                if (e == 0)
                {
                    Q4.text = "O";
                    Jogador1 = true;
                }
                if (e == 1)
                {
                    Q6.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q1.text == "O" && Q8.text == "O" && Q3.text == "" && Q4.text == "" && Q6.text == "")
            {
                if (e == 0)
                {
                    Q4.text = "O";
                    Jogador1 = true;
                }
                if (e == 1)
                {
                    Q6.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q3.text == "O" && Q8.text == "O" && Q1.text == "" && Q4.text == "" && Q6.text == "")
            {
                if (e == 0)
                {
                    Q4.text = "O";
                    Jogador1 = true;
                }
                if (e == 1)
                {
                    Q6.text = "O";
                    Jogador1 = true;
                }
            }
        }
        
        // IA NO MEIO E CANTO, COM X CANTO OPOSTO //
        if (Rodada == 4)
        {
            float l = Random.Range(0, 2);
            if (Q1.text == "O" && Q5.text == "O" && Q9.text == "X" && Q3.text == "" && Q7.text == "")
            {
                if(l == 0)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (l == 1)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q3.text == "O" && Q5.text == "O" && Q7.text == "X" && Q1.text == "" && Q9.text == "")
            {
                if (l == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (l == 1)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q7.text == "O" && Q5.text == "O" && Q3.text == "X" && Q1.text == "" && Q9.text == "")
            {
                if (l == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (l == 1)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q9.text == "O" && Q5.text == "O" && Q1.text == "X" && Q3.text == "" && Q7.text == "")
            {
                if (l == 0)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (l == 1)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
            }
        }

        // CANTO OPOSTO DA IA //
        if (Rodada == 3)
        {
            float y = Random.Range(0, 2);
            if (Q1.text == "O" && Q5.text == "X" && Q9.text == "X" && Q3.text == "" && Q7.text == "")
            {
                if (y == 0)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                else if (y == 1)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q9.text == "O" && Q5.text == "X" && Q1.text == "X" && Q3.text == "" && Q7.text == "")
            {
                if (y == 0)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (y == 1)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q3.text == "O" && Q5.text == "X" && Q7.text == "X" && Q1.text == "" && Q9.text == "")
            {
                if (y == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (y == 1)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q7.text == "O" && Q5.text == "X" && Q3.text == "X" && Q1.text == "" && Q9.text == "")
            {
                if (y == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (y == 1)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }       
        }

        // CANTO OPOSTO E IA NO MEIO //
        if (Rodada == 3)
        {
            // DIAGONAIS
            float z = Random.Range(0, 2);           
            if (Q5.text == "O" && Q1.text == "X" && Q9.text == "X" && Q3.text == "" && Q7.text == "")
            {
                if(z == 0)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (z == 1)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q3.text == "X" && Q7.text == "X" && Q1.text == "" && Q9.text == "")
            {
                if (z == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (z == 1)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            // LINHA E COLUNA
            float n = Random.Range(0, 4);
            if (Q5.text == "O" && Q4.text == "X" && Q6.text == "X" && Q1.text == "" && Q3.text == "" && Q7.text == "" && Q9.text == "")
            {
                if (n == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (n == 1)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (n == 2)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
                if (n == 3)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q2.text == "X" && Q8.text == "X" && Q1.text == "" && Q3.text == "" && Q7.text == "" && Q9.text == "")
            {
                if (n == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (n == 1)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (n == 2)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
                if (n == 3)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
        }

        // TRIANGULO //
        if (Rodada == 3)
        {
            float a = Random.Range(0, 2);
            if (Q5.text == "O" && Q2.text == "X" && Q4.text == "X"&& Q3.text == "" && Q7.text == "")
            {
                if (a == 0)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (a == 1)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }                                            
            }
            if (Q5.text == "O" && Q6.text == "X" && Q8.text == "X" && Q3.text == "" && Q7.text == "")
            {
                if (a == 0)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (a == 1)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q2.text == "X" && Q6.text == "X" && Q1.text == "" && Q9.text == "")
            {
                if (a == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (a == 1)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q4.text == "X" && Q8.text == "X" && Q1.text == "" && Q9.text == "")
            {
                if (a == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (a == 1)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
        }

        // CANTO E MEIO //
        if (Rodada == 3)
        {
            if (Q5.text == "O" && Q2.text == "X" && Q9.text == "X" && Q3.text == "")
            {
                Q3.text = "O";
                Jogador1 = true;
            }
            if (Q5.text == "O" && Q2.text == "X" && Q7.text == "X" && Q1.text == "")
            {
                Q1.text = "O";
                Jogador1 = true;
            }
            if (Q5.text == "O" && Q8.text == "X" && Q1.text == "X" && Q7.text == "")
            {
                Q7.text = "O";
                Jogador1 = true;
            }
            if (Q5.text == "O" && Q8.text == "X" && Q3.text == "X" && Q9.text == "")
            {
                Q9.text = "O";
                Jogador1 = true;
            }
            if (Q5.text == "O" && Q4.text == "X" && Q3.text == "X" && Q1.text == "")
            {
                Q1.text = "O";
                Jogador1 = true;
            }
            if (Q5.text == "O" && Q4.text == "X" && Q9.text == "X" && Q7.text == "")
            {
                Q7.text = "O";
                Jogador1 = true;
            }
            if (Q5.text == "O" && Q6.text == "X" && Q1.text == "X" && Q3.text == "")
            {
                Q3.text = "O";
                Jogador1 = true;
            }
            if (Q5.text == "O" && Q6.text == "X" && Q7.text == "X" && Q9.text == "")
            {
                Q9.text = "O";
                Jogador1 = true;
            }
        }

        // ALTERNANDO //
        if (Rodada == 7)
        {
            float b = Random.Range(0, 2);
            if (Q5.text == "X" && Q4.text == "" && Q6.text == "")
            {
                if (b == 0)
                {
                    Q4.text = "O";
                    Jogador1 = true;
                }
                if (b == 1)
                {
                    Q6.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "X" && Q2.text == "" && Q8.text == "")
            {
                if (b == 0)
                {
                    Q2.text = "O";
                    Jogador1 = true;
                }
                if (b == 1)
                {
                    Q8.text = "O";
                    Jogador1 = true;
                }
            }
        }

        // ALTERNANDO COM IA NO MEIO //
        if (Rodada == 5)
        {
            float c = Random.Range(0, 4);
            if (Q2.text == "O" && Q5.text == "O" && Q4.text == "" && Q6.text == "" && Q7.text == "" && Q9.text == "")
            {
                if (c == 0)
                {
                    Q4.text = "O";
                    Jogador1 = true;
                }
                if (c == 1)
                {
                    Q6.text = "O";
                    Jogador1 = true;
                }
                if (c == 2)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
                if (c == 3) 
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q8.text == "O" && Q5.text == "O" && Q4.text == "" && Q6.text == "" && Q1.text == "" && Q3.text == "")
            {
                if (c == 0)
                {
                    Q4.text = "O";
                    Jogador1 = true;
                }
                if (c == 1)
                {
                    Q6.text = "O";
                    Jogador1 = true;
                }
                if (c == 2)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (c == 3) 
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q4.text == "O" && Q5.text == "O" && Q2.text == "" && Q8.text == "" && Q3.text == "" && Q9.text == "")
            {
                if (c == 0)
                {
                    Q2.text = "O";
                    Jogador1 = true;
                }
                if (c == 1)
                {
                    Q8.text = "O";
                    Jogador1 = true;
                }
                if (c == 2)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (c == 3)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q6.text == "O" && Q5.text == "O" && Q2.text == "" && Q8.text == "" && Q1.text == "" && Q7.text == "")
            {
                if (c == 0)
                {
                    Q2.text = "O";
                    Jogador1 = true;
                }
                if (c == 1)
                {
                    Q8.text = "O";
                    Jogador1 = true;
                }
                if (c == 2)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (c == 3)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
            }
        }

        // JOGADA MAIS BURRA //
        if (Rodada == 7)
        {
            float d = Random.Range(0, 2);
            if (Q5.text == "O" && Q1.text == "O" && Q8.text == "O" && Q3.text == "" && Q6.text == "")
            {
                if (d == 0)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
                if (d == 1)
                {
                    Q6.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q3.text == "O" && Q8.text == "O" && Q1.text == "" && Q4.text == "")
            {
                if (d == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (d == 1)
                {
                    Q4.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q7.text == "O" && Q2.text == "O" && Q6.text == "" && Q9.text == "")
            {
                if (d == 0)
                {
                    Q6.text = "O";
                    Jogador1 = true;
                }
                if (d == 1)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q9.text == "O" && Q2.text == "O" && Q4.text == "" && Q7.text == "")
            {
                if (d == 0)
                {
                    Q4.text = "O";
                    Jogador1 = true;
                }
                if (d == 1)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q3.text == "O" && Q4.text == "O" && Q8.text == "" && Q9.text == "")
            {
                if (d == 0)
                {
                    Q8.text = "O";
                    Jogador1 = true;
                }
                if (d == 1)
                {
                    Q9.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q9.text == "O" && Q4.text == "O" && Q2.text == "" && Q3.text == "")
            {
                if (d == 0)
                {
                    Q2.text = "O";
                    Jogador1 = true;
                }
                if (d == 1)
                {
                    Q3.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q1.text == "O" && Q6.text == "O" && Q7.text == "" && Q8.text == "")
            {
                if (d == 0)
                {
                    Q7.text = "O";
                    Jogador1 = true;
                }
                if (d == 1)
                {
                    Q8.text = "O";
                    Jogador1 = true;
                }
            }
            if (Q5.text == "O" && Q7.text == "O" && Q6.text == "O" && Q1.text == "" && Q2.text == "")
            {
                if (d == 0)
                {
                    Q1.text = "O";
                    Jogador1 = true;
                }
                if (d == 1)
                {
                    Q2.text = "O";
                    Jogador1 = true;
                }
            }
        }

        // IA FAZ ULTIMA JOGADA //
        if (Rodada == 8)
        {
            if (Q1.text == "")
            {
                Q1.text = "O";
                Jogador1 = true;
            }
            if (Q2.text == "")
            {
                Q2.text = "O";
                Jogador1 = true;
            }
            if (Q3.text == "")
            {
                Q3.text = "O";
                Jogador1 = true;
            }
            if (Q4.text == "")
            {
                Q4.text = "O";
                Jogador1 = true;
            }
            if (Q6.text == "")
            {
                Q6.text = "O";
                Jogador1 = true;
            }
            if (Q7.text == "")
            {
                Q7.text = "O";
                Jogador1 = true;
            }
            if (Q8.text == "")
            {
                Q8.text = "O";
                Jogador1 = true;
            }
            if (Q9.text == "")
            {
                Q9.text = "O";
                Jogador1 = true;
            }
        }
    }
}

