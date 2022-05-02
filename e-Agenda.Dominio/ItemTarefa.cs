﻿using System;

namespace e_agenda.WinApp
{
    [Serializable]
    public class ItemTarefa
    {
        public string Titulo { get;  set; }
       
        public bool Concluido { get; set; }

        public override string ToString()
        {
            return Titulo;
        }

        public void Concluir()
        {
            Concluido = true;
        }

        public void MarcarPendente()
        {
            Concluido = false;
        }
    }

    
}
