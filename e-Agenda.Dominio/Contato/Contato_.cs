namespace e_agenda.WinApp
{
    public class Contato_
    {
        public Contato_()
        {
        }

        public Contato_(int numero, string nome, string email, string telefone, string empresa, string cargo)
        {
            Numero = numero;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public override string ToString()
        {
            return $"Número: {Numero},  Nome: {Nome},  Email: {Email},  Telefone: {Telefone},  Empresa: {Empresa},  Cargo: {Cargo}";
        }
    }
}
