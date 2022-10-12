public class User
{
    //atributos
    private string user;
    private string senha;
    private string nome;

    //contrutor padrão

    //metódos
    public void SetUser(string p_user) { this.user = p_user; }
    public string GetUser() { return this.user; }

    public void SetSenha(string p_senha) { this.senha = p_senha; }
    public string GetSenha() { return this.senha; }

    public void SetNome(string p_nome) { this.nome = p_nome; }
    public string GetNome() { return this.nome; }
}