using System;
using System.Collections.Generic;

namespace e_agenda.WinApp
{
    public class RepositorioContato
    {
        List<Contato_> contatos = new List<Contato_>();
        private int contador = 0;
        public List<Contato_> SelecionarTodosContatos()
        {
            return contatos;
        }

        public void Inserir(Contato_ novoContato)
        {
            novoContato.Numero = ++contador;
            contatos.Add(novoContato);
        }

        public void Editar(Contato_ contato)
        {
            foreach (var item in contatos)
            {
                if (item.Numero == contato.Numero)
                {
                    item.Nome = contato.Nome;
                    item.Empresa = contato.Empresa;
                    item.Email = contato.Email;
                    item.Telefone = contato.Telefone;
                    item.Cargo = contato.Cargo;

                    break;
                }
            }
        }

        public void Excluir(Contato_ contato)
        {
           contatos.Remove(contato);
        }
    }
}
