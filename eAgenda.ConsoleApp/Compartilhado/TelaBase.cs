﻿using System;

namespace eAgenda.ConsoleApp.Compartilhado
{
    public abstract class TelaBase
    {
        protected string Titulo { get; set; }

        public TelaBase(string titulo)
        {
            Titulo = titulo;
        }

        public virtual string MostrarOpcoes()
        {

            MostrarTitulo(Titulo);

            Console.WriteLine("Digite 1 para Inserir");
            Console.WriteLine("Digite 2 para Editr");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visulizar");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();  

            return opcao;
        }

        protected void MostrarTitulo(string titulo)
        {
            Console.Clear();
            Console.WriteLine(titulo);
            Console.WriteLine();
        }
    }
}
