﻿using System;
using System.Collections.Generic;

namespace e_agenda.WinApp
{
    public class RepositorioTarefa
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        private int contador = 0;
        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }

        public void Inserir(Tarefa novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            tarefas.Add(novaTarefa);
        }

        public void Editar(Tarefa tarefa)
        {
            foreach (var item in tarefas)
            {
                if (item.Numero == tarefa.Numero)
                {
                    item.Titulo = tarefa.Titulo;
                    break;
                }
            }
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }
    }
}