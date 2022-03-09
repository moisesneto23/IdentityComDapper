namespace IdentityDapper.Model
{
    public class AplicacaoUsuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string NormalizeUserName { get; set; }
        public string Email { get; set; }
        public string NormalizeEmail { get; set; }
        public bool ConfirmeEmail { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public bool ConfirmeTelefone { get; set; }
        public bool DoisFatoresEhAtivado { get; set; }


    }
}
